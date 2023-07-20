<?php
//Simpanlah dengan nama file : Barang.php
require_once 'database.php';
class Barang 
{
    private $db;
    private $table = 'barang';
    public $kode_barang = "";
    public $nama = "";
    public $harga = "" ;
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
    public function get_by_kode(int $kode_barang)
    {
        $query = "SELECT * FROM $this->table WHERE kode_barang = $kode_barang";
        $result_set = $this->db->query($query);   
        return $result_set;
    }
    public function insert(): int
    {
        $query = "INSERT INTO $this->table (`kode_barang`,`nama`,`harga`) VALUES ('$this->kode_barang','$this->nama','$this->harga')";
        $this->db->query($query);
        return $this->db->insert_id();
    }
    public function update(int $id): int
    {
        $query = "UPDATE $this->table SET kode_barang = '$this->kode_barang', nama = '$this->nama', harga = '$this->harga'
        WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function update_by_kode($kode_barang): int
    {
        $query = "UPDATE $this->table SET kode_barang = '$this->kode_barang', nama = '$this->nama', harga = '$this->harga'
        WHERE kode_barang  = $kode_barang";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete(int $id): int
    {
        $query = "DELETE FROM $this->table WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete_by_kode($kode_barang): int
    {
        $query = "DELETE FROM $this->table WHERE kode_barang = $kode_barang";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}
?>