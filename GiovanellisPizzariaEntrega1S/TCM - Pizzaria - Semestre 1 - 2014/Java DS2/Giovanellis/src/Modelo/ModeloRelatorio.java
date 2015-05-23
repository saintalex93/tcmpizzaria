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

    public ModeloRelatorio(String DataInicial, String DataFinal, double TotalDespesa, double TotalFuncionario, double TotalCompras, double TotalPedidos, double TotalPromocao, double TotalGeral, double TotalGastos, double TotalReceita) {
        this.DataInicial = DataInicial;
        this.DataFinal = DataFinal;
        this.TotalDespesa = TotalDespesa;
        this.TotalFuncionario = TotalFuncionario;
        this.TotalCompras = TotalCompras;
        this.TotalPedidos = TotalPedidos;
        this.TotalPromocao = TotalPromocao;
        this.TotalGeral = TotalGeral;
        this.TotalGastos = TotalGastos;
        this.TotalReceita = TotalReceita;
    }
    private String DataInicial, DataFinal;
    private double TotalDespesa, TotalFuncionario, TotalCompras, TotalPedidos, TotalPromocao, TotalGeral, TotalGastos, TotalReceita;
            
      

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
     * @return the TotalDespesa
     */
    public double getTotalDespesa() {
        return TotalDespesa;
    }

    /**
     * @param TotalDespesa the TotalDespesa to set
     */
    public void setTotalDespesa(double TotalDespesa) {
        this.TotalDespesa = TotalDespesa;
    }

    /**
     * @return the TotalFuncionario
     */
    public double getTotalFuncionario() {
        return TotalFuncionario;
    }

    /**
     * @param TotalFuncionario the TotalFuncionario to set
     */
    public void setTotalFuncionario(double TotalFuncionario) {
        this.TotalFuncionario = TotalFuncionario;
    }

    /**
     * @return the TotalCompras
     */
    public double getTotalCompras() {
        return TotalCompras;
    }

    /**
     * @param TotalCompras the TotalCompras to set
     */
    public void setTotalCompras(double TotalCompras) {
        this.TotalCompras = TotalCompras;
    }

    /**
     * @return the TotalPedidos
     */
    public double getTotalPedidos() {
        return TotalPedidos;
    }

    /**
     * @param TotalPedidos the TotalPedidos to set
     */
    public void setTotalPedidos(double TotalPedidos) {
        this.TotalPedidos = TotalPedidos;
    }

    /**
     * @return the TotalPromocao
     */
    public double getTotalPromocao() {
        return TotalPromocao;
    }

    /**
     * @param TotalPromocao the TotalPromocao to set
     */
    public void setTotalPromocao(double TotalPromocao) {
        this.TotalPromocao = TotalPromocao;
    }

    /**
     * @return the TotalGeral
     */
    public double getTotalGeral() {
        return TotalGeral;
    }

    /**
     * @param TotalGeral the TotalGeral to set
     */
    public void setTotalGeral(double TotalGeral) {
        this.TotalGeral = TotalGeral;
    }

    /**
     * @return the TotalGastos
     */
    public double getTotalGastos() {
        return TotalGastos;
    }

    /**
     * @param TotalGastos the TotalGastos to set
     */
    public void setTotalGastos(double TotalGastos) {
        this.TotalGastos = TotalGastos;
    }

    /**
     * @return the TotalReceita
     */
    public double getTotalReceita() {
        return TotalReceita;
    }

    /**
     * @param TotalReceita the TotalReceita to set
     */
    public void setTotalReceita(double TotalReceita) {
        this.TotalReceita = TotalReceita;
    }
    
}
