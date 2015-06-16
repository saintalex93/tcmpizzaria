/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controlador;

import giovanellis.SqlServer;
import java.sql.ResultSet;
import Modelo.ModeloLembrete;
import java.sql.PreparedStatement;
import java.sql.SQLException;

/**
 *
 * @author Alex
 */
public class ControladorLembrete {

    public ControladorLembrete(SqlServer conn, ResultSet rs) {
        this.conn = conn;
        this.rs = rs;
    }
      private SqlServer conn;
    private ResultSet rs;

    public ControladorLembrete() {
        this.conn = conn;
    }
    
     public void InserirLembrete (ModeloLembrete ModLembrete) throws SQLException, Exception
    {
        conn = new SqlServer();
        PreparedStatement pst = conn.getConexao().prepareCall("{call USP_JAVA_INSERELEMBRETE (?,?,?,?,?,?)}");
        pst.setDouble(1, ModLembrete.getCodFuncionario()); 
        pst.setString(2, ModLembrete.getAssunto());
        pst.setString(3, ModLembrete.getMensagem());
        pst.setString(4, ModLembrete.getDataCriacao());
        pst.setString(5, ModLembrete.getDataAviso());
        pst.setInt(6, ModLembrete.getAviso());
        pst.executeUpdate();
    }
     
      public boolean AlterarLembrete (ModeloLembrete ModLembrete) throws SQLException, Exception
    {
        conn = new SqlServer();
        PreparedStatement pst = conn.getConexao().prepareCall("{call USP_JAVA_ALTERALEMBRETE (?,?,?,?,?,?)}");
        pst.setInt(1, ModLembrete.getCodLembrete()); 
        pst.setInt(2, ModLembrete.getCodFuncionario());
        pst.setString(3, ModLembrete.getAssunto());
        pst.setString(4, ModLembrete.getMensagem());
        pst.setString(5, ModLembrete.getDataAviso());
        pst.setInt(6, ModLembrete.getAviso());
        if(pst.executeUpdate() > 0) 
           return true;
        else
            return false;
    }
      
      
        public boolean ExcluirLembrete (ModeloLembrete ModLembrete) throws SQLException, Exception
    {
        conn = new SqlServer();
        PreparedStatement pst = conn.getConexao().prepareCall("{call USP_JAVA_EXCLUILEMBRETE (?)}");
        pst.setInt(1, ModLembrete.getCodLembrete()); 
     
        if(pst.executeUpdate() > 0) 
           return true;
        else
            return false;
    }
    

    /**
     * @return the conn
     */
    public SqlServer getConn() {
        return conn;
    }

    /**
     * @param conn the conn to set
     */
    public void setConn(SqlServer conn) {
        this.conn = conn;
    }

    /**
     * @return the rs
     */
    public ResultSet getRs() {
        return rs;
    }

    /**
     * @param rs the rs to set
     */
    public void setRs(ResultSet rs) {
        this.rs = rs;
    }
}
