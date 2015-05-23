/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package giovanellis;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

/**
 *
 * @author Alex
 */
public class SqlServer {

    private Connection con;
    public Statement stm;
    public ResultSet rs;

    public SqlServer() throws Exception {

        String usuario = "sa", senha = "123456", url = "jdbc:jtds:sqlserver://ALEX-PC:1433/Pizzaria";
        Class.forName("net.sourceforge.jtds.jdbc.Driver");
        con = DriverManager.getConnection(url, usuario, senha);

//        String usuario = "aluno", senha = "etesp", url = "jdbc:jtds:sqlserver://LAB23T-17:1433/Pizzaria";
//        Class.forName("net.sourceforge.jtds.jdbc.Driver");
//        con = DriverManager.getConnection(url, usuario, senha);
    }

    public Connection getConexao() {
        return getCon();
    }

    public void conectar() {

    }

    public void executaSql(String sql) {
        try {
            stm = con.createStatement(rs.TYPE_SCROLL_INSENSITIVE, rs.CONCUR_READ_ONLY);
            rs = stm.executeQuery(sql);
        } catch (Exception e) {
        }

    }

    /**
     * @return the con
     */
    public Connection getCon() {
        return con;
    }

    /**
     * @param con the con to set
     */
    public void setCon(Connection con) {
        this.con = con;
    }

    public Statement createStatement() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

}
