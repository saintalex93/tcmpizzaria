/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controlador;

import Modelo.ModeloBackup;
import giovanellis.SqlServer;
import java.sql.PreparedStatement;

public class ControladorBackup {
    
    SqlServer con;
    
    
      public boolean Incluir (ModeloBackup objBackup) throws Exception{
       
        SqlServer con = new SqlServer();
        //String Sql = "Insert into TipoDespesa(NomeDespesa, SituacaoDespesa) values (?,'Ativo' )";
        PreparedStatement ps = con.getConexao().prepareCall("{call USP_JAVA_BACKUP (?)}");
        ps.setString(1, objBackup.getCaminho());
        if(ps.executeUpdate() >0)
        return true;
        else
        return false;
    }
    
    
}
