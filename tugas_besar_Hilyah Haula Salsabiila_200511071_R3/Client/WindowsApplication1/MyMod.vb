Module MyMod
    Public api_folder As String = "uas"
    Public barang_api As String = "http://a0837476.xsph.ru/" & api_folder & "/barang_api.php"
    Public barang_baru As Boolean
    Public pelanggan_api As String = "http://a0837476.xsph.ru/" & api_folder & "/pelanggan_api.php"
    Public pelanggan_baru As Boolean
    Public transaksi_api As String = "http://a0837476.xsph.ru/" & api_folder & "/transaksi_api.php"
    Public transaksi_baru As Boolean
    Public users_api As String = "http://a0837476.xsph.ru/" & api_folder & "/users_api.php"


    Public LoginForm As New Form_login
    Public Dashboard As New Form_utama
    Public PelangganForm As New Form_pelanggan
    Public BarangForm As New Form_barang
    Public TransaksiForm As New Form_transaksi


    Public admin_role As Boolean = False
    Public pelanggan_role As Boolean = False
    Public login_valid As Boolean = False

End Module
