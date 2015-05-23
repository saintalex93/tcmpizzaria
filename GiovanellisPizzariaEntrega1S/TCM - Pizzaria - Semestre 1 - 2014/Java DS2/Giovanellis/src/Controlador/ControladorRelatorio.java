/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */
package Controlador;
import giovanellis.SqlServer;
import Modelo.ModeloRelatorio;
import java.sql.CallableStatement;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.Locale;
import java.util.concurrent.Callable;
import javax.swing.JOptionPane;
/**
 *
 * @author ETESP
 */
public class ControladorRelatorio {
    SqlServer con;
    ModeloRelatorio ModeloRelatorio;
    ResultSet rs;
    

    public ControladorRelatorio() throws Exception {
        con = new SqlServer();
        ModeloRelatorio = new ModeloRelatorio();
    }
    
    
     public void Incluir (ModeloRelatorio objRela) throws Exception{

         CallableStatement stmt = con.getConexao().prepareCall("{call SP_Rel (?,?)}");
        stmt.setString(1, objRela.getDataInicial());
        stmt.setString(2,objRela.getDataFinal());
        stmt.execute();
        rs = stmt.getResultSet();
         
    }
    
    
}
