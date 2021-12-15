
Imports System.Data.SqlClient
Imports System.Data


Module Conexion

    Public CadenaConexion As New SqlConnection("Data Source=.;Initial Catalog=SistemaTransporte;User ID=sa;Password=12345678")
    Public ConexionBD As String = "Data Source=.;Initial Catalog=SistemaTransporte;User ID=sa;Password=12345678"


    Public UsuarioAccesoDatos As String
    Public UsuarioAccesoCodigo As String

    Public Actualizar As Integer
    Public VaciarCajas As Integer

    Public asiento As Integer

    'VARIABLES PARA BOLETA DE VENTA'

    Public DNI As String
    Public codigoClientes As String
    Public PlacaBus As String
    Public CodigoBus As String


    'busqueda cliente 
    Public clienteencontrado As Integer
    Public BCodigoCliente As String


End Module




