using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PG5_PRACTICA1.Clases;
using PG5_PRACTICA1.Model;

namespace PG5_PRACTICA1
{
    public partial class DatosEmpleado : System.Web.UI.Page
    {
        CEmpleado cemp = new CEmpleado();
        protected void Page_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            GridView1.DataSource = cemp.MostrarEmpleado();
            GridView1.DataBind();
        }

        

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            hf_control.Value = Convert.ToString(GridView1.DataKeys[GridView1.SelectedRow.RowIndex].Value);
            Panel1.Visible = true;
            empleado obj = cemp.ExtraerEmpleado(Convert.ToInt32(hf_control.Value));
            TxtCodigo1.Text = Convert.ToString(obj.codigo);
            TxtNombre1.Text = obj.nombre;
            TxtSalario_Bruto1.Text = Convert.ToString(obj.salario_bruto);
            TxtSalario_Neto1.Text = Convert.ToString(obj.salario_neto);
            TxtDeducciones1.Text = Convert.ToString(obj.deducciones);
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onMouseOver", "this.style.cursor = 'pointer'");
                e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(GridView1, "select$" + e.Row.RowIndex.ToString()));
            }
        }

        protected void Btn_Guardar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(TxtCodigo.Text);
            string nombre = TxtNombre.Text;
            decimal salarioBruto = Convert.ToDecimal(TxtSalario_Bruto.Text);
            decimal salarioNeto = Convert.ToDecimal(TxtSalario_Neto.Text);
            decimal deducciones = Convert.ToDecimal(TxtDeducciones.Text);
            cemp.Guardar(codigo, nombre, salarioBruto, salarioNeto, deducciones);
            Cargar();
        }

        protected void Btn_Cerrar_Click1(object sender, EventArgs e)
        {
            Panel1.Visible = false;
        }

        protected void Btn_Borrar_Click1(object sender, EventArgs e)
        {
            empleado obj = cemp.BorrarEmpleado(Convert.ToInt32(hf_control.Value));
        }
    }
}