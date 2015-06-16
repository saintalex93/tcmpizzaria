/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Modelo;

import java.util.Date;


public class ModeloLancamentoDespesas {
    
    
   private String NomeDespesa;
   private Double Valor;
   private String DataVencimento;
    private String DataPagamento;
    private int Codigo;

    public ModeloLancamentoDespesas(String NomeDespesa, Double Valor, String DataVencimento, String DataPagamento, int Codigo) {
        this.NomeDespesa = NomeDespesa;
        this.Valor = Valor;
        this.DataVencimento = DataVencimento;
        this.DataPagamento = DataPagamento;
        this.Codigo = Codigo;
    }


    
    public ModeloLancamentoDespesas() {
        
        
    }

    /**
     * @return the NomeDespesa
     */
    public String getNomeDespesa() {
        return NomeDespesa;
    }

    /**
     * @param NomeDespesa the NomeDespesa to set
     */
    public void setNomeDespesa(String NomeDespesa) {
        this.NomeDespesa = NomeDespesa;
    }

    /**
     * @return the Valor
     */
    public Double getValor() {
        return Valor;
    }

    /**
     * @param Valor the Valor to set
     */
    public void setValor(Double Valor) {
        this.Valor = Valor;
    }

    /**
     * @return the DataVencimento
     */
    public String getDataVencimento() {
        return DataVencimento;
    }

    /**
     * @param DataVencimento the DataVencimento to set
     */
    public void setDataVencimento(String DataVencimento) {
        this.DataVencimento = DataVencimento;
    }

    /**
     * @return the DataPagamento
     */
    public String getDataPagamento() {
        return DataPagamento;
    }

    /**
     * @param DataPagamento the DataPagamento to set
     */
    public void setDataPagamento(String DataPagamento) {
        this.DataPagamento = DataPagamento;
    }

    /**
     * @return the Codigo
     */
    public int getCodigo() {
        return Codigo;
    }

    /**
     * @param Codigo the Codigo to set
     */
    public void setCodigo(int Codigo) {
        this.Codigo = Codigo;
    }
    
}
