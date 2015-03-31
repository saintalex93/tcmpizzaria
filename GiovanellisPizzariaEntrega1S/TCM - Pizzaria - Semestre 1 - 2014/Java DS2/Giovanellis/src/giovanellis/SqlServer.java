/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package giovanellis;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;

/**
 *
 * @author Alex
 */
public class SqlServer {
    
    private Connection con;
    
    
    public SqlServer() throws Exception {
        String usuario = "sa", senha = "123456", url = "jdbc:jtds:sqlserver://ALEX-PC:1433/Pizzaria";
        Class.forName("net.sourceforge.jtds.jdbc.Driver");
        con = DriverManager.getConnection(url, usuario, senha);
    }
    public Connection getConexao(){
        return getCon();
    }

     public void conectar (){
        
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
    
}

 
