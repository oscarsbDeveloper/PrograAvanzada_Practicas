<%@ Page Language="C#" EnableEventValidation ="false" AutoEventWireup="true" CodeBehind="DatosEmpleado.aspx.cs" Inherits="PG5_PRACTICA1.DatosEmpleado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HiddenField runat="server" ID="hf_control" />
        <div>
            Codigo<asp:TextBox ID="TxtCodigo" runat="server"></asp:TextBox><br/>
            Nombre<asp:TextBox ID="TxtNombre" runat="server"></asp:TextBox><br/>
            Salario Bruto<asp:TextBox ID="TxtSalario_Bruto" runat="server"></asp:TextBox><br/>
            Salario Neto<asp:TextBox ID="TxtSalario_Neto" runat="server"></asp:TextBox><br/>
            Deducciones<asp:TextBox ID="TxtDeducciones" runat="server"></asp:TextBox><br/>
            <asp:Button ID="Btn_Guardar" runat="server" Text="Guardar" OnClick="Btn_Guardar_Click"/><br/>

            <h3>Mostrar datos Empleado</h3>

            <asp:GridView DataKeynames="codigo" ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" OnRowDataBound="GridView1_RowDataBound">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>

                <asp:Panel ID="Panel1" runat="server" Visible="false">
                    Carnet<asp:TextBox ID="TxtCodigo1" runat="server"></asp:TextBox><br/>
                    Nombre<asp:TextBox ID="TxtNombre1" runat="server"></asp:TextBox><br/>
                    Salario Bruto<asp:TextBox ID="TxtSalario_Bruto1" runat="server"></asp:TextBox><br/>
                    Salario Neto<asp:TextBox ID="TxtSalario_Neto1" runat="server"></asp:TextBox><br/>
                    Deducciones<asp:TextBox ID="TxtDeducciones1" runat="server"></asp:TextBox><br/>
                    <asp:Button ID="Btn_Cerrar" runat="server" Text="Cerrar" OnClick="Btn_Cerrar_Click1"/>
                    <asp:Button ID="Btn_Borrar" runat="server" Text="Borrar" OnClick="Btn_Borrar_Click1"/>
                </asp:Panel>

        </div>
    </form>
</body>
</html>
