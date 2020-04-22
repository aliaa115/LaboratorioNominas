using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioNominas.Mantenimientos.Procesos
{
    public class Cls_Mantenimientos
    {
        /*
         ID DE TABLAS:
            1 = empleado
            2 = puesto
            3 = impuesto
            4 = concepto
            5 = departamento
            6 = bancos
            7 = cuentas

        ORDEN DE LOS DATOS EN RETURN PARA datos:
            1 = alias
            2 = ayuda
            3 = tabla
            4 = form
            5 = nombre
            6 = noForaneas
            
        ORDEN DE LOS DATOS EN RETURN PARA foraneas:
            1 = tabla
            2 = campo
            3 = modo
             */
        public (string[], string, string, string, string, int) datos(int tabla)
        {
            switch (tabla)
            {
                case 1:
                    string[] alias1 = { "Empleado", "Nombre", "Puesto", "Departamento", "Sueldo", "Estado" };
                    return (alias1, "1", "empleado", "de Empleados", "EMPLEADO", 2);

                case 2:
                    string[] alias2 = { "Puesto", "Nombre", "Estado" };
                    return (alias2, "1", "puesto", "de Puestos", "PUESTO", 0);
                    /*
                case 3:
                    string[] alias3 = { "Impuesto", "Nombres", "", "Estado" };
                    return (alias3, "1", "impuesto", "de Clientes", "CLIENTE", 0);
                    */
                case 4:
                    string[] alias4 = { "Concepto", "Nombres", "Estado" };
                    return (alias4, "1", "concepto", "de Conceptos", "CONCEPTO", 0);

                case 5:
                    string[] alias5 = { "Depto.", "Nombre", "Estado" };
                    return (alias5, "1", "departamento", "de Departamentos", "DEPARTAMENTO", 0);

                case 6:
                    string[] alias6 = { "Banco", "Saldo", "Estado" };
                    return (alias6, "1", "banco", "de Bancos", "BANCO", 0);

                case 7:
                    string[] alias7 = { "Cuenta", "Saldo", "Estado" };
                    return (alias7, "1", "cuenta", "de Cuentas", "CUENTA", 0);

                default:
                    break;
            }
            return (null, null, null, null, null, 0);
        }

        public (string, string, int) foraneas(int tabla, int no)
        {
            switch (tabla)
            {
                //bono
                case 1:
                    switch (no)
                    {
                        case 1:
                            return ("puesto", "nombre_puesto", 1);
                        case 2:
                            return ("departamento", "nombre_departamento", 1);
                    }
                    break;

                //material
                case 5:
                    switch (no)
                    {
                        case 1:
                            return ("categoria", "CATEGORIA", 0);
                    }
                    break;

                //mora
                case 7:
                    switch (no)
                    {
                        case 1:
                            return ("cliente", "MEMBRESIA", 0);
                    }
                    break;

                default:
                    break;
            }
            return ("", "", 0);
        }

    }
}
