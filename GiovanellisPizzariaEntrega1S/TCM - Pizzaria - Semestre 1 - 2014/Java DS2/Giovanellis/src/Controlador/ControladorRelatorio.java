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

    private SqlServer con;
    private ModeloRelatorio ModeloRelatorio;
    private ResultSet rs;

    public ControladorRelatorio() throws Exception {
        con = new SqlServer();
        ModeloRelatorio = new ModeloRelatorio();
    }

    public double[] Incluir(ModeloRelatorio objRela) throws Exception {
        double[] results = new double[8];// Variavel para preenchermos com os resultados da procedures
        CallableStatement stmt = con.getConexao().prepareCall("{call USP_JAVA_Relatorios (?,?,?,?,?,?,?)}");
        stmt.setString(1, objRela.getDataInicial());
        stmt.setString(2, objRela.getDataFinal());
        stmt.setInt(3, objRela.getBinarioFuncionario());
        stmt.setInt(4, objRela.getBinarioDespesa());
        stmt.setInt(5, objRela.getBinarioCompras());
        stmt.setInt(6, objRela.getBinarioPedidos());
        stmt.setInt(7, objRela.getBinarioPromocao());
        stmt.execute();
        setRs(stmt.getResultSet());

        if (getRs().next()) {// Se a procedure retornar valores, preencher a variável com esses valores retornados
            results[0] = getRs().getDouble("Promocoes");// Aqui são os nomes dos campos, conforme você cria na Query
            results[1] = getRs().getDouble("Pedidos");
            results[2] = getRs().getDouble("Compras");
            results[3] = getRs().getDouble("Funcionario");
            results[4] = getRs().getDouble("Despesa");
            results[5] = getRs().getDouble("Prejuizo");
            results[6] = getRs().getDouble("Receita");
            results[7] = getRs().getDouble("TotalGeral");

            // Preenchido o array, retorna ele pra funcção que chamou
            return results;

        }
        return results;

      // stmt.close();
    }

    /**
     * @return the con
     */
    public SqlServer getCon() {
        return con;
    }

    /**
     * @param con the con to set
     */
    public void setCon(SqlServer con) {
        this.con = con;
    }

    /**
     * @return the ModeloRelatorio
     */
    public ModeloRelatorio getModeloRelatorio() {
        return ModeloRelatorio;
    }

    /**
     * @param ModeloRelatorio the ModeloRelatorio to set
     */
    public void setModeloRelatorio(ModeloRelatorio ModeloRelatorio) {
        this.ModeloRelatorio = ModeloRelatorio;
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
