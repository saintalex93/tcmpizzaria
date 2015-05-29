/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controlador;

import Modelo.clsLancamentoDespesas;
import giovanellis.SqlServer;
import java.sql.Date;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.Vector;

/**
 *
 * @author Alex
 */
public class ControladorLancamentoDespesas {
    SqlServer con;
   
    
    public Vector listar(String campo, String pesq) throws Exception {
        
       //String sql = "select *  from Despesa as desp inner join  TipoDespesa as D on codDespesa = codTipoDespesa ";
        String sql = "select * from Despesa ";

       PreparedStatement ps = con.getConexao().prepareStatement(sql);
       Vector tabela = new Vector();
       ResultSet rs = ps.executeQuery();
       while(rs.next()){
           Vector novalinha = new Vector();
           novalinha.add(rs.getInt("codDespesa"));
           novalinha.add(rs.getDouble("ValorDespesa"));
            novalinha.add(rs.getDate("DataPagamento"));
             novalinha.add(rs.getDate("DataVencimento"));
              novalinha.add(rs.getInt("TipoDespesa"));
             // novalinha.add(rs.getString("NomeDespesa"));
         
           tabela.add(novalinha);
       }
       return tabela;
    }
    
    
       public boolean Incluir (clsLancamentoDespesas objDesp) throws Exception{
       
        SqlServer con = new SqlServer();
        String Sql = "Insert into Despesa(TipoDespesa, ValorDespesa, DataPagamento, DataVencimento ) values (?,?,?)";
        PreparedStatement ps = con.getConexao().prepareStatement(Sql);
        ps.setDouble(1, objDesp.getValorDespesa());
        ps.setDate(2, (Date) objDesp.getDataPagamento());
        ps.setDate(3, (Date) objDesp.getDataVencimento());
        
        if(ps.executeUpdate() >0)
        return true;
        else
        return false;
    }
    
}
