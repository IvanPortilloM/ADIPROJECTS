using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ADIGGM.Herramientas
{
    public partial class frmDifImpuestos : ADIGGM.FrmPrincipal
    {
        // Cadena de conexión a la base de datos
        string cadenaConexion = ADIGGM.CapaDatos.Conexion.Cadena("Covibase");

        public frmDifImpuestos()
        {
            InitializeComponent();
        }

        private DataTable ObtenerDatosBodega(int bodega, DateTime desde, DateTime hasta)
        {
            string consulta = ObtenerConsultaPorBodega(bodega);

            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(cadenaConexion))
            using (SqlCommand cmd = new SqlCommand(consulta, conn))
            {
                cmd.Parameters.AddWithValue("@desde", desde);
                cmd.Parameters.AddWithValue("@hasta", hasta);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }

        private string ObtenerConsultaPorBodega(int bodega)
        {
            switch (bodega)
            {
                case 1:
                    return "SELECT DISTINCT 'Compras' AS tipo,cpdocument.cnumdocume as documento,cpprovedor.ccompania as cliente," +
                        "cpdocument.dfechacrea AS fecha, SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS CostoMercaderia," +
                        "SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS VentaBruta, AVG(cpdetadocu.ndescuento) AS PorcDescuento, " +
                        "SUM(cpdetadocu.nmontodesc) AS Descuento,SUM(CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciouni * cpdetadocu.ncantidad)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaGravada," +
                        "SUM(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaExcenta, " +
                        "SUM((CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) + " +
                        "(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) ) AS VentaDescuento," +
                        "SUM(cpdetadocu.nmtoimpues) AS ImpuestoVentas, cpdocument.nmontotota as Total FROM cpdocument " +
                        "INNER JOIN cpdetadocu ON cpdocument.cllavedocu = cpdetadocu.cllavedocu LEFT JOIN cpprovedor ON cpdocument.ccodprovee = cpprovedor.ccodprovee " +
                        "WHERE cpdocument.dfechacrea BETWEEN @desde and @hasta " +
                        "AND cpdocument.cstatdocum NOT IN ('D','N') AND cpdetadocu.ccodbodega ='0001'" +
                        "GROUP BY cpdocument.cnumdocume,cpprovedor.ccompania,cpdocument.dfechacrea,cpdocument.nmontotota ";
                case 2:
                    return "SELECT DISTINCT 'Compras' AS tipo,cpdocument.cnumdocume as documento,cpprovedor.ccompania as cliente," +
                        "cpdocument.dfechacrea AS fecha, SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS CostoMercaderia," +
                        "SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS VentaBruta, AVG(cpdetadocu.ndescuento) AS PorcDescuento, " +
                        "SUM(cpdetadocu.nmontodesc) AS Descuento,SUM(CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciouni * cpdetadocu.ncantidad)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaGravada," +
                        "SUM(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaExcenta, " +
                        "SUM((CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) + " +
                        "(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) ) AS VentaDescuento," +
                        "SUM(cpdetadocu.nmtoimpues) AS ImpuestoVentas, cpdocument.nmontotota as Total FROM cpdocument " +
                        "INNER JOIN cpdetadocu ON cpdocument.cllavedocu = cpdetadocu.cllavedocu LEFT JOIN cpprovedor ON cpdocument.ccodprovee = cpprovedor.ccodprovee " +
                        "WHERE cpdocument.dfechacrea BETWEEN @desde and @hasta " +
                        "AND cpdocument.cstatdocum NOT IN ('D','N') AND cpdetadocu.ccodbodega ='0001'" +
                        "AND round(CASE WHEN cpdetadocu.nmtoimpues <> 0 THEN (((cpdetadocu.nmtoimpues * 100) / CASE WHEN cpdetadocu.ncantidad > 0 THEN (cpdetadocu.npreciouni*cpdetadocu.ncantidad) ELSE 1 END))ELSE 0 END,0) = 18.00 " +
                        "GROUP BY cpdocument.cnumdocume,cpprovedor.ccompania,cpdocument.dfechacrea,cpdocument.nmontotota ";
                case 3:
                    return "SELECT DISTINCT 'Compras' AS tipo,cpdocument.cnumdocume as documento,cpprovedor.ccompania as cliente," +
                        "cpdocument.dfechacrea AS fecha, SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS CostoMercaderia," +
                        "SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS VentaBruta, AVG(cpdetadocu.ndescuento) AS PorcDescuento, " +
                        "SUM(cpdetadocu.nmontodesc) AS Descuento,SUM(CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciouni * cpdetadocu.ncantidad)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaGravada," +
                        "SUM(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaExcenta, " +
                        "SUM((CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) + " +
                        "(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) ) AS VentaDescuento," +
                        "SUM(cpdetadocu.nmtoimpues) AS ImpuestoVentas, cpdocument.nmontotota as Total FROM cpdocument " +
                        "INNER JOIN cpdetadocu ON cpdocument.cllavedocu = cpdetadocu.cllavedocu LEFT JOIN cpprovedor ON cpdocument.ccodprovee = cpprovedor.ccodprovee " +
                        "WHERE cpdocument.dfechacrea BETWEEN @desde and @hasta " +
                        "AND cpdocument.cstatdocum NOT IN ('D','N') AND cpdetadocu.ccodbodega ='1001'" +
                        "GROUP BY cpdocument.cnumdocume,cpprovedor.ccompania,cpdocument.dfechacrea,cpdocument.nmontotota ";
                case 4:
                    return "SELECT DISTINCT 'Compras' AS tipo,cpdocument.cnumdocume as documento,cpprovedor.ccompania as cliente," +
                        "cpdocument.dfechacrea AS fecha, SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS CostoMercaderia," +
                        "SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS VentaBruta, AVG(cpdetadocu.ndescuento) AS PorcDescuento, " +
                        "SUM(cpdetadocu.nmontodesc) AS Descuento,SUM(CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciouni * cpdetadocu.ncantidad)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaGravada," +
                        "SUM(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaExcenta, " +
                        "SUM((CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) + " +
                        "(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) ) AS VentaDescuento," +
                        "SUM(cpdetadocu.nmtoimpues) AS ImpuestoVentas, cpdocument.nmontotota as Total FROM cpdocument " +
                        "INNER JOIN cpdetadocu ON cpdocument.cllavedocu = cpdetadocu.cllavedocu LEFT JOIN cpprovedor ON cpdocument.ccodprovee = cpprovedor.ccodprovee " +
                        "WHERE cpdocument.dfechacrea BETWEEN @desde and @hasta " +
                        "AND cpdocument.cstatdocum NOT IN ('D','N') AND cpdetadocu.ccodbodega ='1001'" +
                        "AND round(CASE WHEN cpdetadocu.nmtoimpues <> 0 THEN (((cpdetadocu.nmtoimpues * 100) / CASE WHEN cpdetadocu.ncantidad > 0 THEN (cpdetadocu.npreciouni*cpdetadocu.ncantidad) ELSE 1 END))ELSE 0 END,0) = 18.00 " +
                        "GROUP BY cpdocument.cnumdocume,cpprovedor.ccompania,cpdocument.dfechacrea,cpdocument.nmontotota ";

                case 5:
                    return "SELECT DISTINCT 'Compras' AS tipo,cpdocument.cnumdocume as documento,cpprovedor.ccompania as cliente," +
                        "cpdocument.dfechacrea AS fecha, SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS CostoMercaderia," +
                        "SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS VentaBruta, AVG(cpdetadocu.ndescuento) AS PorcDescuento, " +
                        "SUM(cpdetadocu.nmontodesc) AS Descuento,SUM(CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciouni * cpdetadocu.ncantidad)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaGravada," +
                        "SUM(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaExcenta, " +
                        "SUM((CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) + " +
                        "(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) ) AS VentaDescuento," +
                        "SUM(cpdetadocu.nmtoimpues) AS ImpuestoVentas, cpdocument.nmontotota as Total FROM cpdocument " +
                        "INNER JOIN cpdetadocu ON cpdocument.cllavedocu = cpdetadocu.cllavedocu LEFT JOIN cpprovedor ON cpdocument.ccodprovee = cpprovedor.ccodprovee " +
                        "WHERE cpdocument.dfechacrea BETWEEN @desde and @hasta " +
                        "AND cpdocument.cstatdocum NOT IN ('D','N') AND (cpdetadocu.ccodbodega ='0002' or cpdetadocu.ccodbodega ='0009') " +
                        "GROUP BY cpdocument.cnumdocume,cpprovedor.ccompania,cpdocument.dfechacrea,cpdocument.nmontotota ";
                case 6:
                    return "SELECT DISTINCT 'Compras' AS tipo,cpdocument.cnumdocume as documento,cpprovedor.ccompania as cliente," +
                        "cpdocument.dfechacrea AS fecha, SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS CostoMercaderia," +
                        "SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS VentaBruta, AVG(cpdetadocu.ndescuento) AS PorcDescuento, " +
                        "SUM(cpdetadocu.nmontodesc) AS Descuento,SUM(CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciouni * cpdetadocu.ncantidad)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaGravada," +
                        "SUM(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaExcenta, " +
                        "SUM((CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) + " +
                        "(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) ) AS VentaDescuento," +
                        "SUM(cpdetadocu.nmtoimpues) AS ImpuestoVentas, cpdocument.nmontotota as Total FROM cpdocument " +
                        "INNER JOIN cpdetadocu ON cpdocument.cllavedocu = cpdetadocu.cllavedocu LEFT JOIN cpprovedor ON cpdocument.ccodprovee = cpprovedor.ccodprovee " +
                        "WHERE cpdocument.dfechacrea BETWEEN @desde and @hasta " +
                        "AND cpdocument.cstatdocum NOT IN ('D','N') AND (cpdetadocu.ccodbodega ='0003' or cpdetadocu.ccodbodega ='0010') " +
                        "GROUP BY cpdocument.cnumdocume,cpprovedor.ccompania,cpdocument.dfechacrea,cpdocument.nmontotota ";
                case 7:
                    return "SELECT DISTINCT 'Compras' AS tipo,cpdocument.cnumdocume as documento,cpprovedor.ccompania as cliente," +
                        "cpdocument.dfechacrea AS fecha, SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS CostoMercaderia," +
                        "SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS VentaBruta, AVG(cpdetadocu.ndescuento) AS PorcDescuento, " +
                        "SUM(cpdetadocu.nmontodesc) AS Descuento,SUM(CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciouni * cpdetadocu.ncantidad)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaGravada," +
                        "SUM(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaExcenta, " +
                        "SUM((CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) + " +
                        "(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) ) AS VentaDescuento," +
                        "SUM(cpdetadocu.nmtoimpues) AS ImpuestoVentas, cpdocument.nmontotota as Total FROM cpdocument " +
                        "INNER JOIN cpdetadocu ON cpdocument.cllavedocu = cpdetadocu.cllavedocu LEFT JOIN cpprovedor ON cpdocument.ccodprovee = cpprovedor.ccodprovee " +
                        "WHERE cpdocument.dfechacrea BETWEEN @desde and @hasta " +
                        "AND cpdocument.cstatdocum NOT IN ('D','N') AND (cpdetadocu.ccodbodega ='0004' or cpdetadocu.ccodbodega ='0011') " +
                        "GROUP BY cpdocument.cnumdocume,cpprovedor.ccompania,cpdocument.dfechacrea,cpdocument.nmontotota ";
                case 8:
                    return "SELECT DISTINCT 'Compras' AS tipo,cpdocument.cnumdocume as documento,cpprovedor.ccompania as cliente," +
                        "cpdocument.dfechacrea AS fecha, SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS CostoMercaderia," +
                        "SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS VentaBruta, AVG(cpdetadocu.ndescuento) AS PorcDescuento, " +
                        "SUM(cpdetadocu.nmontodesc) AS Descuento,SUM(CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciouni * cpdetadocu.ncantidad)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaGravada," +
                        "SUM(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaExcenta, " +
                        "SUM((CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) + " +
                        "(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) ) AS VentaDescuento," +
                        "SUM(cpdetadocu.nmtoimpues) AS ImpuestoVentas, cpdocument.nmontotota as Total FROM cpdocument " +
                        "INNER JOIN cpdetadocu ON cpdocument.cllavedocu = cpdetadocu.cllavedocu LEFT JOIN cpprovedor ON cpdocument.ccodprovee = cpprovedor.ccodprovee " +
                        "WHERE cpdocument.dfechacrea BETWEEN @desde and @hasta " +
                        "AND cpdocument.cstatdocum NOT IN ('D','N') AND (cpdetadocu.ccodbodega ='0005' or cpdetadocu.ccodbodega ='0012') " +
                        "GROUP BY cpdocument.cnumdocume,cpprovedor.ccompania,cpdocument.dfechacrea,cpdocument.nmontotota ";
                case 9:
                    return "SELECT DISTINCT 'Compras' AS tipo,cpdocument.cnumdocume as documento,cpprovedor.ccompania as cliente," +
                        "cpdocument.dfechacrea AS fecha, SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS CostoMercaderia," +
                        "SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS VentaBruta, AVG(cpdetadocu.ndescuento) AS PorcDescuento, " +
                        "SUM(cpdetadocu.nmontodesc) AS Descuento,SUM(CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciouni * cpdetadocu.ncantidad)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaGravada," +
                        "SUM(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaExcenta, " +
                        "SUM((CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) + " +
                        "(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) ) AS VentaDescuento," +
                        "SUM(cpdetadocu.nmtoimpues) AS ImpuestoVentas, cpdocument.nmontotota as Total FROM cpdocument " +
                        "INNER JOIN cpdetadocu ON cpdocument.cllavedocu = cpdetadocu.cllavedocu LEFT JOIN cpprovedor ON cpdocument.ccodprovee = cpprovedor.ccodprovee " +
                        "WHERE cpdocument.dfechacrea BETWEEN @desde and @hasta " +
                        "AND cpdocument.cstatdocum NOT IN ('D','N') AND (cpdetadocu.ccodbodega ='0006' or cpdetadocu.ccodbodega ='0013') " +
                        "GROUP BY cpdocument.cnumdocume,cpprovedor.ccompania,cpdocument.dfechacrea,cpdocument.nmontotota ";
                case 10:
                    return "SELECT DISTINCT 'Compras' AS tipo,cpdocument.cnumdocume as documento,cpprovedor.ccompania as cliente," +
                        "cpdocument.dfechacrea AS fecha, SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS CostoMercaderia," +
                        "SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS VentaBruta, AVG(cpdetadocu.ndescuento) AS PorcDescuento, " +
                        "SUM(cpdetadocu.nmontodesc) AS Descuento,SUM(CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciouni * cpdetadocu.ncantidad)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaGravada," +
                        "SUM(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaExcenta, " +
                        "SUM((CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) + " +
                        "(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) ) AS VentaDescuento," +
                        "SUM(cpdetadocu.nmtoimpues) AS ImpuestoVentas, cpdocument.nmontotota as Total FROM cpdocument " +
                        "INNER JOIN cpdetadocu ON cpdocument.cllavedocu = cpdetadocu.cllavedocu LEFT JOIN cpprovedor ON cpdocument.ccodprovee = cpprovedor.ccodprovee " +
                        "WHERE cpdocument.dfechacrea BETWEEN @desde and @hasta " +
                        "AND cpdocument.cstatdocum NOT IN ('D','N') AND (cpdetadocu.ccodbodega ='0008' or cpdetadocu.ccodbodega ='0014') " +
                        "GROUP BY cpdocument.cnumdocume,cpprovedor.ccompania,cpdocument.dfechacrea,cpdocument.nmontotota ";
                case 11:
                    return "SELECT DISTINCT 'Compras' AS tipo,cpdocument.cnumdocume as documento,cpprovedor.ccompania as cliente," +
                        "cpdocument.dfechacrea AS fecha, SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS CostoMercaderia," +
                        "SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS VentaBruta, AVG(cpdetadocu.ndescuento) AS PorcDescuento, " +
                        "SUM(cpdetadocu.nmontodesc) AS Descuento,SUM(CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciouni * cpdetadocu.ncantidad)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaGravada," +
                        "SUM(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaExcenta, " +
                        "SUM((CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) + " +
                        "(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) ) AS VentaDescuento," +
                        "SUM(cpdetadocu.nmtoimpues) AS ImpuestoVentas, cpdocument.nmontotota as Total FROM cpdocument " +
                        "INNER JOIN cpdetadocu ON cpdocument.cllavedocu = cpdetadocu.cllavedocu LEFT JOIN cpprovedor ON cpdocument.ccodprovee = cpprovedor.ccodprovee " +
                        "WHERE cpdocument.dfechacrea BETWEEN @desde and @hasta " +
                        "AND cpdocument.cstatdocum NOT IN ('D','N') AND (cpdetadocu.ccodbodega ='1004' or cpdetadocu.ccodbodega ='1011') " +
                        "GROUP BY cpdocument.cnumdocume,cpprovedor.ccompania,cpdocument.dfechacrea,cpdocument.nmontotota ";
                case 12:
                    return "SELECT DISTINCT 'Compras' AS tipo,cpdocument.cnumdocume as documento,cpprovedor.ccompania as cliente," +
                        "cpdocument.dfechacrea AS fecha, SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS CostoMercaderia," +
                        "SUM(cpdetadocu.npreciouni*cpdetadocu.ncantidad) AS VentaBruta, AVG(cpdetadocu.ndescuento) AS PorcDescuento, " +
                        "SUM(cpdetadocu.nmontodesc) AS Descuento,SUM(CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciouni * cpdetadocu.ncantidad)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaGravada," +
                        "SUM(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END) AS VentaExcenta, " +
                        "SUM((CASE WHEN cpdetadocu.nmtoimpues > 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) + " +
                        "(CASE WHEN cpdetadocu.nmtoimpues = 0 THEN ((cpdetadocu.npreciotot+cpdetadocu.nmontodesc-cpdetadocu.nmtoimpues)-cpdetadocu.nmontodesc) ELSE 0 END ) ) AS VentaDescuento," +
                        "SUM(cpdetadocu.nmtoimpues) AS ImpuestoVentas, cpdocument.nmontotota as Total FROM cpdocument " +
                        "INNER JOIN cpdetadocu ON cpdocument.cllavedocu = cpdetadocu.cllavedocu LEFT JOIN cpprovedor ON cpdocument.ccodprovee = cpprovedor.ccodprovee " +
                        "WHERE cpdocument.dfechacrea BETWEEN @desde and @hasta " +
                        "AND cpdocument.cstatdocum NOT IN ('D','N') AND (cpdetadocu.ccodbodega ='0007' or cpdetadocu.ccodbodega ='0015') " +
                        "GROUP BY cpdocument.cnumdocume,cpprovedor.ccompania,cpdocument.dfechacrea,cpdocument.nmontotota ";
                default:
                    throw new ArgumentException("Bodega no válida");
            }
        }
        private readonly string[] nombresHojas = {
            "Tienda ADI", "Tienda ADI 18%", "Tienda ESL", "Tienda ESL 18%",
            "Caf. CH", "Caf. GMSB", "Caf. CRI", "Caf. GML", "Caf. HE", "Caf. AQH", "Caf. ESL", "Caf. Laure"
        };

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string fechaInicio = mskInicio.Text; // Ej: "27/05/2025"
            string fechaFin = mskFin.Text;       // Ej: "27/05/2025"
            DateTime desde = DateTime.ParseExact(fechaInicio, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime hasta = DateTime.ParseExact(fechaFin, "dd/MM/yyyy", CultureInfo.InvariantCulture)
                                     .AddDays(1).AddSeconds(-1); // Ajusta al último segundo del día

            string rutaTemporal = Path.Combine(Path.GetTempPath(), $"Reporte_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx");

            using (var workbook = new XLWorkbook())
            {
                for (int i = 0; i < 12; i++)
                {
                    DataTable tabla = ObtenerDatosBodega(i + 1, desde, hasta);

                    var hoja = workbook.Worksheets.Add(tabla, nombresHojas[i]);
                    hoja.Columns().AdjustToContents();

                    // Formatear columnas específicas
                    hoja.Column("D").Style.DateFormat.Format = "dd/MM/yyyy"; // Columna fecha

                    // Columnas numéricas (ajusta si cambian de lugar)
                    for (char col = 'E'; col <= 'M'; col++)
                    {
                        hoja.Column(col.ToString()).Style.NumberFormat.Format = "#,##0.00";
                    }
                }

                workbook.SaveAs(rutaTemporal);

                // Abrir el archivo directamente
                Process.Start(new ProcessStartInfo()
                {
                    FileName = rutaTemporal,
                    UseShellExecute = true
                });
            }
        }

        private void frmDifImpuestos_Load(object sender, EventArgs e)
        {
            mskInicio.Text = DateTime.Now.ToString();
            mskFin.Text = DateTime.Now.ToString();
        }
    }
}
