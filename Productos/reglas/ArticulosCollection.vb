Imports System.ComponentModel
Imports System.Text
Public Class ArticulosCollection

    Inherits BindingList(Of ArticuloClass)
    Protected Overloads Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)
        MyBase.OnAddingNew(e)

        e.NewObject = New ArticuloClass
    End Sub

    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides Function FindCore(prop As PropertyDescriptor, ByVal key As Object) As Integer
        For Each Articulo In Me
            If prop.GetValue(Articulo).Equals(key) Then
                Return Me.IndexOf(Articulo)
            End If
        Next

        Return -1
    End Function

    Public Function TraerArticulo() As ArticulosCollection

        'Si la lista ya esta cargada la limpiamos.
        If Me.Items.Count > 0 Then Me.ClearItems()

        'crea la intancia de base de datos
        Dim ObjBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim MiArticulo As ArticuloClass

        ObjBaseDatos.objTabla = "Articulo"
        'devuelve los datos de la base de la tabla
        MiDataTable = ObjBaseDatos.TraerTodo

        For Each dr As DataRow In MiDataTable.Rows
            'crea la instancia por cada campo
            MiArticulo = New ArticuloClass

            MiArticulo.Id = CInt(dr("Id"))
            MiArticulo.Descripcion = dr("Descripcion")
            MiArticulo.IdRubro = CInt(dr("IdRubro"))

            Me.Add(MiArticulo)

        Next

        Return Me
    End Function

    Public Sub InsertarArticulo(ByVal MiArticulo As ArticuloClass)

        Dim ObjBasedeDato As New BaseDatosClass
        'busca la tabla Curso
        ObjBasedeDato.objTabla = "Articulo"

        Dim vsql As New StringBuilder
        ' vsql.Append("(Id")
        vsql.Append("(Descripcion)")
        vsql.Append("(IdRubro)")

        vsql.Append(" VALUES ")

        ' vsql.Append("('" & MiArticulo.id & "'")
        vsql.Append("('" & MiArticulo.Descripcion & "')")
        vsql.Append("('" & MiArticulo.IdRubro & "')")

        MiArticulo.Id = ObjBasedeDato.Insertar(vsql.ToString)
        Me.Add(MiArticulo)

    End Sub

    Public Sub EliminarArticulo(ByVal MiArticulo As ArticuloClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Articulo"

        Dim resultado As Boolean
        resultado = objBaseDatos.Eliminar(MiArticulo.Id)

        If resultado Then

            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiArticulo)

            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)

            Me.RemoveAt(Me.FindCore(myProperty, MiArticulo.Id))

        Else
            MessageBox.Show("No fue posible eliminar el registro.")
        End If

    End Sub

    Public Sub ActualizarArticulo(ByVal MiArticulo As ArticuloClass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base personas.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Articulo"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        'vSQL.Append("Id='" & MiCurso.Id.ToString & "'")
        vSQL.Append("Descripcion='" & MiArticulo.Descripcion & "'")
        vSQL.Append("IdRubro='" & MiArticulo.IdRubro & "'")


        'Actualizo la tabla personas con el Id.
        Dim resultado As Boolean
        'El método actualizar es una función que devuelve True o False
        'Según como haya resultado la operación sobre la tabla SQL.
        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiArticulo.Id)

        If resultado Then
            'El código a continuación sirve para localizar el ítem en la lista
            'en este caso un persona.
            ' Creates a new collection and assign it the properties for modulo.
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiArticulo)

            'Sets an PropertyDescriptor to the specific property Id.
            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)
            Me.Items.Item(Me.FindCore(myProperty, MiArticulo.Id)) = MiArticulo
        Else
            MessageBox.Show("No fue posible modificar el registro.")
        End If

    End Sub
End Class
