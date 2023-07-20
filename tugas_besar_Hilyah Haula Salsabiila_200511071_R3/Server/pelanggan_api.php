<?php
require_once 'database.php';
require_once 'Pelanggan.php';
$db = new MySQLDatabase();
$pelanggan = new Pelanggan($db);
$id=0;
$kode_pelanggan=0;
// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];
// Handle the different HTTP methods
switch ($method) {
    case 'GET':
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['kode_pelanggan'])){
            $kode_pelanggan = $_GET['kode_pelanggan'];
        }
        if($id>0){    
            $result = $pelanggan->get_by_id($id);
        }elseif($kode_pelanggan>0){
            $result = $pelanggan->get_by_kode($kode_pelanggan);
        } else {
            $result = $pelanggan->get_all();
        }        
       
        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }
        
        header('Content-Type: application/json');
        echo json_encode($val);
        break;
    
    case 'POST':
        // Add a new pelanggan
        $pelanggan->kode_pelanggan = $_POST['kode_pelanggan'];
        $pelanggan->nama_pelanggan = $_POST['nama_pelanggan'];
        $pelanggan->alamat = $_POST['alamat'];
        $pelanggan->telepon = $_POST['telepon'];
       
        $pelanggan->insert();
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Pelanggan created successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Pelanggan not created.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
        
    case 'PUT':
        // Update an existing data
        $_PUT = [];
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['kode_pelanggan'])){
            $kode_pelanggan = $_GET['kode_pelanggan'];
        }
        parse_str(file_get_contents("php://input"), $_PUT);
        $pelanggan->kode_pelanggan = $_PUT['kode_pelanggan'];
        $pelanggan->nama_pelanggan = $_PUT['nama_pelanggan'];
        $pelanggan->alamat = $_PUT['alamat'];
        $pelanggan->telepon = $_PUT['telepon'];
        if($id>0){    
            $pelanggan->update($id);
        }elseif($kode_pelanggan<>""){
            $pelanggan->update_by_kode($kode_pelanggan);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Pelanggan updated successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Pelanggan update failed.';
        }        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    case 'DELETE':
        // Delete a user
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['kode_pelanggan'])){
            $kode_pelanggan = $_GET['kode_pelanggan'];
        }
        if($id>0){    
            $pelanggan->delete($id);
        }elseif($kode_pelanggan>0){
            $pelanggan->delete_by_kode($kode_pelanggan);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Pelanggan deleted successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Pelanggan delete failed.';
        }        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    default:
        header("HTTP/1.0 405 Method Not Allowed");
        break;
    }
$db->close()
?>