/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controlador;
import Modelo.clsPedidos;
import com.toedter.calendar.JDateChooser;
import giovanellis.SqlServer;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Timestamp;

/**
 *
 * @author Alex
 */

public class ControladorPedidos {
   
    
    
 public String TotalPedido(String estado1, String estado2, String estado3,
                          String estado4, String estado5, Timestamp data1, Timestamp data2
         
) throws Exception {
        SqlServer con = new SqlServer();
  String sql = "Select * from FX_Total_Pedido(?,?,?,?,?,?,?)", total = "";
    PreparedStatement ps = con.getConexao().prepareStatement(sql);
    ps.setString(1, estado1);
    ps.setString(2, estado2);
    ps.setString(3, estado3);
    ps.setString(4, estado4);
    ps.setString(5, estado5);
    ps.setTimestamp(6, data1);
    ps.setTimestamp(7, data2);
    ResultSet rs = ps.executeQuery();
    while(rs.next()){
        total = rs.getString("[Valor Total]");
    }
    return total;
}}

 
    
    

