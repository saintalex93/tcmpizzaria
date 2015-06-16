/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controlador;

import Modelo.ModeloLancamentoDespesas;
import giovanellis.SqlServer;
import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Vector;
import javax.swing.JOptionPane;

/**
 *
 * @author Alex
 */
public class ControladorLancamentoDespesas {
    SqlServer con;
   
  
       public void Incluir (ModeloLancamentoDespesas objDesp) throws Exception {
       
        SqlServer con = new SqlServer();
        con.conectar();
        
           try {
       // String Sql = "Insert into Despesa(TipoDespesa, ValorDespesa, DataPagamento, DataVencimento) values (?,?,?,?)";
       PreparedStatement ps = con.getConexao().prepareCall("{call JAVA_USP_LancarDespesa (?,?,?,?)}");
        ps.setInt(1, objDesp.getCodigo());
        ps.setDouble(2, objDesp.getValor());
        ps.setString(3, objDesp.getDataPagamento());
        ps.setString(4, objDesp.getDataVencimento());
        ps.executeUpdate();
        
     
           } catch (Exception e) {
               JOptionPane.showMessageDialog(null,"Erro na inserção dos valores"+ e);
           }
       }





}
       
    
       
       
    

