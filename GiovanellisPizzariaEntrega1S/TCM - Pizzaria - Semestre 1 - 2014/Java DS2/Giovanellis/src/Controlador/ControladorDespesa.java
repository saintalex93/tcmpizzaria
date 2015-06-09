/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controlador;

import Modelo.clsDespesa;
import Visao.frmCadastrarDespesa;
import giovanellis.SqlServer;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Vector;

/**
 *
 * @author Alex
 */
public class ControladorDespesa {
    SqlServer con;
     
     
    public boolean Incluir (clsDespesa objDesp) throws Exception{
       
        SqlServer con = new SqlServer();
        //String Sql = "Insert into TipoDespesa(NomeDespesa, SituacaoDespesa) values (?,'Ativo' )";
        PreparedStatement ps = con.getConexao().prepareCall("{call JAVA_USP_InserirTipoDespesa (?)}");
        ps.setString(1, objDesp.getNomeDespesa());
        if(ps.executeUpdate() >0)
        return true;
        else
        return false;
    }
    
  
     
    public boolean Editar(clsDespesa objDesp) throws Exception {
        SqlServer con = new SqlServer();
        //String sql = "update TipoDespesa set NomeDespesa = ?, SituacaoDespesa = ? where codTipoDespesa = ?";
        PreparedStatement ps = con.getConexao().prepareCall("{call JAVA_USP_AlterarTipoDespesa (?,?,?)}");
        ps.setInt(1, objDesp.getCodDespesa());
        ps.setString(2, objDesp.getNomeDespesa());
        ps.setString(3, objDesp.getSituacaoDespesa());
          
        
        if(ps.executeUpdate() > 0) 
           return true;
        else
            return false;
    }
    
    
     
     
    
    
}



