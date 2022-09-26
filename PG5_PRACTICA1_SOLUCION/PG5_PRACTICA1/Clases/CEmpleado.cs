using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PG5_PRACTICA1.Model;

namespace PG5_PRACTICA1.Clases
{
    public class CEmpleado
    {
        pg5_practica1Entities db = new pg5_practica1Entities();
        public List<empleado>MostrarEmpleado()
        {
            return db.empleado.ToList();
        }

        public void Guardar(int p_codigo, string p_nombre, decimal p_salario_bruto, decimal p_salario_neto, decimal p_deducciones)
        {
            empleado emp = new empleado();
            emp.codigo = p_codigo;
            emp.nombre = p_nombre;
            emp.salario_bruto = p_salario_bruto;
            emp.salario_neto = p_salario_neto;
            emp.deducciones = p_deducciones;
            db.empleado.Add(emp);
            db.SaveChanges();
        }

        public empleado ExtraerEmpleado(int p_codigo)
        {
            empleado obj = db.empleado.Single(x => x.codigo == p_codigo);
            return obj;
        }

        public empleado BorrarEmpleado(int p_codigo)
        {
            empleado obj = db.empleado.Single(x => x.codigo == p_codigo);
            db.empleado.Remove(obj);
            db.SaveChanges();
            return obj;
        }

    }
}