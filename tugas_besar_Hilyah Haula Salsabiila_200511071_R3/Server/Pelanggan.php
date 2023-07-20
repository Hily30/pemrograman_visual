<?php
//Simpanlah dengan nama_pelanggan file : Pelanggan.php
require_once 'database.php';
class Pelanggan 
{
    private $db;
    private $table = 'pelanggan';
    public $kode_pelanggan = "";
    public $nama_pelanggan = "";
    public $alamat = "";
    public $telepon = "";
    public function __construct(MySQLDatabase $db)
    {
        $this->db = $db;
    }
    public function get_all() 
    {
        $query = "SELECT * FROM $this->table";
        $result_set = $this->db->query($query);
        return $result_set;
    }
    public function get_by_id(int $id)
    {
        $query = "SELECT * FROM $this->table WHERE id = $id";
        $result_set = $this->db->query($query);   
        return $result_set;
    }
    public function get_by_kode(int $kode_pelanggan)
    {
        $query = "SELECT * FROM $this->table WHERE kode_pelanggan = $kode_pelanggan";
        $result_set = $this->db->query($query);   
        return $result_set;
    }
    public function insert(): int
    {
        $query = "INSERT INTO $this->table (`kode_pelanggan`,`nama_pelanggan`,`alamat`,`telepon`) VALUES ('$this->kode_pelanggan','$this->nama_pelanggan','$this->alamat','$this->telepon')";
        $this->db->query($query);
        return $this->db->insert_id();
    }
    public function update(int $id): int
    {
        $query = "UPDATE $this->table SET kode_pelanggan = '$this->kode_pelanggan', nama_pelanggan = '$this->nama_pelanggan', alamat = '$this->alamat', telepon = '$this->telepon' 
        WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function update_by_kode($kode_pelanggan): int
    {
        $query = "UPDATE $this->table SET kode_pelanggan = '$this->kode_pelanggan', nama_pelanggan = '$this->nama_pelanggan', alamat = '$this->alamat', telepon = '$this->telepon' 
        WHERE kode_pelanggan  = $kode_pelanggan";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete(int $id): int
    {
        $query = "DELETE FROM $this->table WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete_by_kode($kode_pelanggan): int
    {
        $query = "DELETE FROM $this->table WHERE kode_pelanggan = $kode_pelanggan";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}
?>