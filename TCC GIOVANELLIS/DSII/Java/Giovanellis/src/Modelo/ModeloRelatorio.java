/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;



/**
 *
 * @author Alex
 */
public class ModeloRelatorio {

    public ModeloRelatorio(String DataInicial, String DataFinal, int BinarioFuncionario, int BinarioDespesa, int BinarioCompras, int BinarioPedidos, int BinarioPromocao) {
        this.DataInicial = DataInicial;
        this.DataFinal = DataFinal;
        this.BinarioFuncionario = BinarioFuncionario;
        this.BinarioDespesa = BinarioDespesa;
        this.BinarioCompras = BinarioCompras;
        this.BinarioPedidos = BinarioPedidos;
        this.BinarioPromocao = BinarioPromocao;
    }
    private int BinarioFuncionario, BinarioDespesa, BinarioCompras, BinarioPedidos,BinarioPromocao;      
      private String DataInicial, DataFinal;

    public ModeloRelatorio() {
    }

    /**
     * @return the DataInicial
     */
    public String getDataInicial() {
        return DataInicial;
    }

    /**
     * @param DataInicial the DataInicial to set
     */
    public void setDataInicial(String DataInicial) {
        this.DataInicial = DataInicial;
    }

    /**
     * @return the DataFinal
     */
    public String getDataFinal() {
        return DataFinal;
    }

    /**
     * @param DataFinal the DataFinal to set
     */
    public void setDataFinal(String DataFinal) {
        this.DataFinal = DataFinal;
    }

    /**
     * @return the BinarioFuncionario
     */
    public int getBinarioFuncionario() {
        return BinarioFuncionario;
    }

    /**
     * @param BinarioFuncionario the BinarioFuncionario to set
     */
    public void setBinarioFuncionario(int BinarioFuncionario) {
        this.BinarioFuncionario = BinarioFuncionario;
    }

    /**
     * @return the BinarioDespesa
     */
    public int getBinarioDespesa() {
        return BinarioDespesa;
    }

    /**
     * @param BinarioDespesa the BinarioDespesa to set
     */
    public void setBinarioDespesa(int BinarioDespesa) {
        this.BinarioDespesa = BinarioDespesa;
    }

    /**
     * @return the BinarioCompras
     */
    public int getBinarioCompras() {
        return BinarioCompras;
    }

    /**
     * @param BinarioCompras the BinarioCompras to set
     */
    public void setBinarioCompras(int BinarioCompras) {
        this.BinarioCompras = BinarioCompras;
    }

    /**
     * @return the BinarioPedidos
     */
    public int getBinarioPedidos() {
        return BinarioPedidos;
    }

    /**
     * @param BinarioPedidos the BinarioPedidos to set
     */
    public void setBinarioPedidos(int BinarioPedidos) {
        this.BinarioPedidos = BinarioPedidos;
    }

    /**
     * @return the BinarioPromocao
     */
    public int getBinarioPromocao() {
        return BinarioPromocao;
    }

    /**
     * @param BinarioPromocao the BinarioPromocao to set
     */
    public void setBinarioPromocao(int BinarioPromocao) {
        this.BinarioPromocao = BinarioPromocao;
    }

    /**
     * @return the TotalDespesa
     */
  
    
}
