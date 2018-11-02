Imports System.ComponentModel
Imports System.Text
Public Class RubrosCollection

    Inherits BindingList(Of RubroClass)

    Protected Overloads Sub OnAddingNew(ByVal e As System.ComponentModel.AddingNewEventArgs)
        MyBase.OnAddingNew(e)

        e.NewObject = New RubroClass
    End Sub

    Protected Overrides ReadOnly Property SupportsSearchingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides Function FindCore(prop As PropertyDescriptor, ByVal key As Object) As Integer
        For Each Rubro In Me
            If prop.GetValue(Rubro).Equals(key) Then
                Return Me.IndexOf(Rubro)
            End If
        Next

        Return -1
    End Function

    Public Function TraerRubro() As RubrosCollection

        'Si la lista ya esta cargada la limpiamos.
        If Me.Items.Count > 0 Then Me.ClearItems()

        'crea la intancia de base de datos
        Dim ObjBaseDatos As New BaseDatosClass
        Dim MiDataTable As New DataTable
        Dim MiRubro As RubroClass

        ObjBaseDatos.objTabla = "Rubro"
        'devuelve los datos de la base de la tabla
        MiDataTable = ObjBaseDatos.TraerTodo

        For Each dr As DataRow In MiDataTable.Rows
            'crea la instancia por cada campo
            MiRubro = New RubroClass

            MiRubro.Id = CInt(dr("Id"))
            MiRubro.Descripcion = dr("Descripcion")

            Me.Add(MiRubro)

        Next

        Return Me
    End Function

    Public Sub InsertarRubro(ByVal MiRubro As RubroClass)

        Dim ObjBasedeDato As New BaseDatosClass
        'busca la tabla Curso
        ObjBasedeDato.objTabla = "Rubro"

        Dim vsql As New StringBuilder
        ' vsql.Append("(Id")
        vsql.Append("(Descripcion)")

        vsql.Append(" VALUES ")

        ' vsql.Append("('" & Mirubro.id & "'")
        vsql.Append("('" & MiRubro.Descripcion & "')")

        MiRubro.Id = ObjBasedeDato.Insertar(vsql.ToString)
        Me.Add(MiRubro)

    End Sub

    Public Sub EliminarRubro(ByVal MiRubro As RubroClass)

        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Rubro"

        Dim resultado As Boolean
        resultado = objBaseDatos.Eliminar(MiRubro.Id)

        If resultado Then

            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiRubro)

            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)

            Me.RemoveAt(Me.FindCore(myProperty, MiRubro.Id))
        Else
            MessageBox.Show("No fue posible eliminar el registro.")
        End If

    End Sub

    Public Sub ActualizarRubro(ByVal MiRubro As RubroClass)

        'Instancio el el Objeto BaseDatosClass para acceder al la base personas.
        Dim objBaseDatos As New BaseDatosClass
        objBaseDatos.objTabla = "Rubro"

        Dim vSQL As New StringBuilder
        Dim vResultado As Boolean = False

        'vSQL.Append("Id='" & MiCurso.Id.ToString & "'")
        vSQL.Append("Descripcion='" & MiRubro.Descripcion & "'")


        'Actualizo la tabla personas con el Id.
        Dim resultado As Boolean
        'El método actualizar es una función que devuelve True o False
        'Según como haya resultado la operación sobre la tabla SQL.
        resultado = objBaseDatos.Actualizar(vSQL.ToString, MiRubro.Id)

        If resultado Then
            'El código a continuación sirve para localizar el ítem en la lista
            'en este caso un persona.
            ' Creates a new collection and assign it the properties for modulo.
            Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(MiRubro)

            'Sets an PropertyDescriptor to the specific property Id.
            Dim myProperty As PropertyDescriptor = properties.Find("Id", False)
            Me.Items.Item(Me.FindCore(myProperty, MiRubro.Id)) = MiRubro
        Else
            MessageBox.Show("No fue posible modificar el registro.")
        End If

    End Sub

End Class
