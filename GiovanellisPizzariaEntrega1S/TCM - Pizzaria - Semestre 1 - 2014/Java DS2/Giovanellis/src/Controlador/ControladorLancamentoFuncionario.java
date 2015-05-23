/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Controlador;
import giovanellis.SqlServer;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import Modelo.ModeloFuncionario;
import java.sql.Date;
import java.sql.SQLException;

/**
 *
 * @author Alex
 */
public class ControladorLancamentoFuncionario {
    private SqlServer conn;
    private ResultSet rs;
    public ControladorLancamentoFuncionario() {
        this.conn = conn;
    }
    
    
    
    public void InserirCliente (ModeloFuncionario fun) throws SQLException, Exception
    {
        conn = new SqlServer();
            String sql = "Insert into Pagamento (ValorPagamento, DataExpedido, TipoPagamento, Cod_Funcionario)"
                +"values(?,?,?,?)";
        PreparedStatement pst = conn.getCon().prepareStatement(sql);
        pst.setDouble(1, fun.getValorPagamento()); 
        pst.setString(2, fun.getDataExpedido());
        pst.setString(3, fun.getTipodeDespesa());
        pst.setInt(4, fun.getCodFuncionario());
        pst.executeUpdate();
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
