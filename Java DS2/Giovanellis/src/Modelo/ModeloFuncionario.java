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
public class ModeloFuncionario {
    
       private int CodFuncionario;
    private double ValorPagamento;
    private String DataExpedido;
    private String TipodeDespesa;

    public ModeloFuncionario(int CodFuncionario, double ValorPagamento, String DataExpedido, String TipodeDespesa) {
        this.CodFuncionario = CodFuncionario;
        this.ValorPagamento = ValorPagamento;
        this.DataExpedido = DataExpedido;
        this.TipodeDespesa = TipodeDespesa;
    }
 
    
    public ModeloFuncionario() {

    }

    /**
     * @return the CodFuncionario
     */
    public int getCodFuncionario() {
        return CodFuncionario;
    }

    /**
     * @param CodFuncionario the CodFuncionario to set
     */
    public void setCodFuncionario(int CodFuncionario) {
        this.CodFuncionario = CodFuncionario;
    }

    /**
     * @return the ValorPagamento
     */
    public double getValorPagamento() {
        return ValorPagamento;
    }

    /**
     * @param ValorPagamento the ValorPagamento to set
     */
    public void setValorPagamento(double ValorPagamento) {
        this.ValorPagamento = ValorPagamento;
    }

    /**
     * @return the DataExpedido
     */
    public String getDataExpedido() {
        return DataExpedido;
    }

    /**
     * @param DataExpedido the DataExpedido to set
     */
    public void setDataExpedido(String DataExpedido) {
        this.DataExpedido = DataExpedido;
    }

    /**
     * @return the TipodeDespesa
     */
    public String getTipodeDespesa() {
        return TipodeDespesa;
    }

    /**
     * @param TipodeDespesa the TipodeDespesa to set
     */
    public void setTipodeDespesa(String TipodeDespesa) {
        this.TipodeDespesa = TipodeDespesa;
    }
}
