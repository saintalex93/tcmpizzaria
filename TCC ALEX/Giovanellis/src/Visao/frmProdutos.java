/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Visao;

import Modelo.ModeloTabelas;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.ImageIcon;
import javax.swing.JOptionPane;
import giovanellis.SqlServer;
import java.awt.Color;
import java.text.DateFormat;
import java.text.DecimalFormat;
import java.text.NumberFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.Locale;
import javax.swing.ListSelectionModel;
import javax.swing.SwingConstants;
import javax.swing.UIManager;
import javax.swing.table.DefaultTableCellRenderer;

/**
 *
 * @author Alex
 */
public class frmProdutos extends javax.swing.JFrame {

    SqlServer conecta;
    SqlServer connCombo;
    NumberFormat z;
    SimpleDateFormat fmt;
    DecimalFormat dfs;
    DecimalFormat un;

    /**
     * Creates new form frmProdutos
     */
    public frmProdutos() throws Exception {
        z = NumberFormat.getCurrencyInstance();
        fmt = new SimpleDateFormat("dd/MM/yyyy");
        dfs = new DecimalFormat("#,###0.000");
        un = new DecimalFormat("#0");
        connCombo = new SqlServer();
        this.setIconImage(new ImageIcon(getClass().getResource("/Imagens/Icone.png")).getImage());
        Color Fundo = new Color(238, 235, 227);
        getContentPane().setBackground(Fundo);
        setAlwaysOnTop(true);
        conecta = new SqlServer();
        conecta.getCon();
        initComponents();
        setAlwaysOnTop(true);

        //preencherTabela("select * from produto as p inner join detalhe_pedido as pe on p.cod_produto = pe.cod_produto inner join pedido as ped on pe.cod_pedido = ped.cod_pedido order by nome_produto asc");
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        JdcInicio = new com.toedter.calendar.JDateChooser();
        JdcFim = new com.toedter.calendar.JDateChooser();
        jScrollPane1 = new javax.swing.JScrollPane();
        JtableProdutos = new javax.swing.JTable();
        jButton1 = new javax.swing.JButton();
        jButton2 = new javax.swing.JButton();
        JcomboPedidos = new javax.swing.JComboBox();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jScrollPane2 = new javax.swing.JScrollPane();
        JTableOrigem = new javax.swing.JTable();
        jLabel2 = new javax.swing.JLabel();
        ChkLocal = new javax.swing.JCheckBox();
        ChkTelefone = new javax.swing.JCheckBox();
        ChkSite = new javax.swing.JCheckBox();
        lblTotal1 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        jLabel1 = new javax.swing.JLabel();
        jScrollPane3 = new javax.swing.JScrollPane();
        JTableInsumos = new javax.swing.JTable();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("Produtos");
        setResizable(false);
        addMouseMotionListener(new java.awt.event.MouseMotionAdapter() {
            public void mouseMoved(java.awt.event.MouseEvent evt) {
                formMouseMoved(evt);
            }
        });
        addWindowListener(new java.awt.event.WindowAdapter() {
            public void windowClosing(java.awt.event.WindowEvent evt) {
                formWindowClosing(evt);
            }
            public void windowOpened(java.awt.event.WindowEvent evt) {
                formWindowOpened(evt);
            }
        });
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        JdcInicio.setForeground(new java.awt.Color(239, 111, 83));
        JdcInicio.setOpaque(false);
        JdcInicio.addPropertyChangeListener(new java.beans.PropertyChangeListener() {
            public void propertyChange(java.beans.PropertyChangeEvent evt) {
                JdcInicioPropertyChange(evt);
            }
        });
        getContentPane().add(JdcInicio, new org.netbeans.lib.awtextra.AbsoluteConstraints(80, 60, 119, -1));

        JdcFim.setForeground(new java.awt.Color(239, 111, 83));
        JdcFim.setOpaque(false);
        JdcFim.addPropertyChangeListener(new java.beans.PropertyChangeListener() {
            public void propertyChange(java.beans.PropertyChangeEvent evt) {
                JdcFimPropertyChange(evt);
            }
        });
        getContentPane().add(JdcFim, new org.netbeans.lib.awtextra.AbsoluteConstraints(370, 60, 119, -1));

        JtableProdutos.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        JtableProdutos.setForeground(new java.awt.Color(88, 55, 66));
        JtableProdutos.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {},
                {},
                {},
                {}
            },
            new String [] {

            }
        ));
        JtableProdutos.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                JtableProdutosMouseClicked(evt);
            }
        });
        jScrollPane1.setViewportView(JtableProdutos);

        getContentPane().add(jScrollPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 170, 500, 126));

        jButton1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton1.setForeground(new java.awt.Color(239, 111, 83));
        jButton1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagens/button.png"))); // NOI18N
        jButton1.setText("Voltar");
        jButton1.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        jButton1.setOpaque(false);
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton1, new org.netbeans.lib.awtextra.AbsoluteConstraints(400, 710, 100, 40));

        jButton2.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jButton2.setForeground(new java.awt.Color(239, 111, 83));
        jButton2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagens/button.png"))); // NOI18N
        jButton2.setText("Calcular");
        jButton2.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        jButton2.setOpaque(false);
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });
        getContentPane().add(jButton2, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 710, 100, 40));

        JcomboPedidos.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        JcomboPedidos.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                JcomboPedidosActionPerformed(evt);
            }
        });
        getContentPane().add(JcomboPedidos, new org.netbeans.lib.awtextra.AbsoluteConstraints(140, 100, 220, -1));

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(88, 55, 66));
        jLabel3.setText("Data Inicial");
        getContentPane().add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 65, -1, -1));

        jLabel4.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(88, 55, 66));
        jLabel4.setText("Data Final");
        getContentPane().add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(310, 65, -1, -1));

        JTableOrigem.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        JTableOrigem.setForeground(new java.awt.Color(88, 55, 66));
        JTableOrigem.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {},
                {},
                {},
                {}
            },
            new String [] {

            }
        ));
        JTableOrigem.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                JTableOrigemMouseClicked(evt);
            }
        });
        jScrollPane2.setViewportView(JTableOrigem);

        getContentPane().add(jScrollPane2, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 370, 500, 110));

        jLabel2.setBackground(new java.awt.Color(88, 55, 66));
        jLabel2.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(239, 111, 83));
        jLabel2.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel2.setText("Consulta de Produtos");
        jLabel2.setOpaque(true);
        getContentPane().add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(-30, -6, 570, 50));

        ChkLocal.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        ChkLocal.setForeground(new java.awt.Color(88, 55, 66));
        ChkLocal.setText("In Loco");
        ChkLocal.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                ChkLocalActionPerformed(evt);
            }
        });
        getContentPane().add(ChkLocal, new org.netbeans.lib.awtextra.AbsoluteConstraints(80, 140, -1, -1));

        ChkTelefone.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        ChkTelefone.setForeground(new java.awt.Color(88, 55, 66));
        ChkTelefone.setText("Telefone");
        ChkTelefone.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                ChkTelefoneActionPerformed(evt);
            }
        });
        getContentPane().add(ChkTelefone, new org.netbeans.lib.awtextra.AbsoluteConstraints(370, 140, -1, -1));

        ChkSite.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N
        ChkSite.setForeground(new java.awt.Color(88, 55, 66));
        ChkSite.setText("Site");
        ChkSite.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                ChkSiteActionPerformed(evt);
            }
        });
        getContentPane().add(ChkSite, new org.netbeans.lib.awtextra.AbsoluteConstraints(230, 140, -1, -1));

        lblTotal1.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        lblTotal1.setForeground(new java.awt.Color(88, 55, 66));
        lblTotal1.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblTotal1.setText("Total");
        getContentPane().add(lblTotal1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 500, 510, 30));

        jLabel5.setBackground(new java.awt.Color(88, 55, 66));
        jLabel5.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(239, 111, 83));
        jLabel5.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel5.setText("Montante por Origem:");
        jLabel5.setOpaque(true);
        getContentPane().add(jLabel5, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 320, 520, 30));

        jLabel1.setBackground(new java.awt.Color(88, 55, 66));
        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(239, 111, 83));
        jLabel1.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel1.setText("Insumos por Produto:");
        jLabel1.setOpaque(true);
        getContentPane().add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 540, 520, 30));

        JTableInsumos.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        JTableInsumos.setForeground(new java.awt.Color(88, 55, 66));
        JTableInsumos.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {},
                {},
                {},
                {}
            },
            new String [] {

            }
        ));
        jScrollPane3.setViewportView(JTableInsumos);

        getContentPane().add(jScrollPane3, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 590, 500, 100));

        setSize(new java.awt.Dimension(526, 797));
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        timer.stop();
        frmHome.binario = 0;
        dispose();

    }//GEN-LAST:event_jButton1ActionPerformed

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
        if (JcomboPedidos.getSelectedIndex() == 0) {
            JOptionPane.showMessageDialog(this, "Escolha um Produto ou Todos.");
        } else if (ValidaDatas()) {

            if (JcomboPedidos.getSelectedIndex() == 1) {
                if (ChkLocal.isSelected() || ChkSite.isSelected() || ChkTelefone.isSelected()) {
                    preencherTabela("select * from produto as p inner join detalhe_pedido as pe on p.cod_produto = pe.cod_produto inner join"
                            + " pedido as ped on pe.cod_pedido = ped.cod_pedido and "
                            + "  (ped.origem like '" + site + "' or ped.origem like '" + telefone + "' or ped.origem like '" + local + "') and "
                            + " data between '" + datainicio + "' and '" + datafim + "' order by data, nome_produto asc");

                    preencherTabelaOrigem("select p.Cod_Produto, p.Nome_Produto, p.Valor_Venda, count (p.Cod_Produto) as Quantidade, sum(p.Valor_Venda) as Total, ped.Origem from produto as p inner"
                            + " join detalhe_pedido as pe on p.cod_produto = pe.cod_produto inner join pedido as ped on pe.cod_pedido = ped.cod_pedido and (ped.origem like '" + site + "' or ped.origem like "+
                            "'" + telefone + "' or ped.origem like '" + local + "') and data between '" + datainicio + "' and '" + datafim + "'"
                            + " group by p.Cod_Produto, p.Nome_Produto, p.Valor_Venda, ped.Origem order by p.Nome_Produto, ped.Origem asc");

                } else {
                    preencherTabela("select * from produto as p inner join detalhe_pedido as pe on p.cod_produto = pe.cod_produto inner join"
                            + " pedido as ped on pe.cod_pedido = ped.cod_pedido and "
                            + " data between '" + datainicio + "' and '" + datafim + "' order by data, nome_produto asc");

                    preencherTabelaOrigem("select p.Cod_Produto, p.Nome_Produto, p.Valor_Venda, count (p.Cod_Produto) as Quantidade, sum(p.Valor_Venda) as Total, ped.Origem from produto as p inner"
                            + " join detalhe_pedido as pe on p.cod_produto = pe.cod_produto inner join pedido as ped on pe.cod_pedido = ped.cod_pedido  and data between '" + datainicio + "' and '" + datafim + "'"
                            + " group by p.Cod_Produto, p.Nome_Produto, p.Valor_Venda, ped.Origem order by p.Nome_Produto, ped.Origem asc");

                }
            } else {
                if (ChkLocal.isSelected() || ChkSite.isSelected() || ChkTelefone.isSelected()) {
                    preencherTabela("select * from produto as p inner join detalhe_pedido as pe on p.cod_produto = pe.cod_produto inner join pedido as ped on pe.cod_pedido = ped.cod_pedido and "+
                            " (ped.origem like '" + site + "' or ped.origem like '" + telefone + "' or ped.origem like '" + local + "')"
                            + "   and data between '" + datainicio + "' and '" + datafim + "' and nome_produto like '" + NomeProduto + "' order by data, nome_produto asc");

                    preencherTabelaOrigem("select p.Cod_Produto, p.Nome_Produto, p.Valor_Venda, count (p.Cod_Produto) as Quantidade, sum(p.Valor_Venda) as Total, ped.Origem from produto as p inner join detalhe_pedido as pe on p.cod_produto = "+
                            "pe.cod_produto inner join pedido as ped on pe.cod_pedido = ped.cod_pedido  and (ped.origem like '" + site + "' or ped.origem like '" + telefone + "' or ped.origem like '" + local + "') and p.Nome_Produto like '" + NomeProduto + "' "+
                            " and data between '" + datainicio + "' and '" + datafim + "' group by p.Cod_Produto, p.Nome_Produto, p.Valor_Venda, ped.Origem order by p.Nome_Produto, ped.Origem asc");
                } else {

                    preencherTabela("select * from produto as p inner join detalhe_pedido as pe on p.cod_produto = pe.cod_produto inner "
                            + "join pedido as ped on pe.cod_pedido = ped.cod_pedido and nome_produto like '" + NomeProduto + "' and data between"
                            + " '" + datainicio + "' and '" + datafim + "' order by data, nome_produto asc");

                    preencherTabelaOrigem("select p.Cod_Produto, p.Nome_Produto, p.Valor_Venda, count (p.Cod_Produto) as Quantidade,"
                            + " sum(p.Valor_Venda) as Total, ped.Origem from produto as p inner join detalhe_pedido as pe on p.cod_produto = "
                            + "pe.cod_produto inner join pedido as ped on pe.cod_pedido = ped.cod_pedido and p.Nome_Produto like '" + NomeProduto + "' and data between '" + datainicio + "' and"
                            + " '" + datafim + "'  group by p.Cod_Produto, p.Nome_Produto, p.Valor_Venda, "
                            + "ped.Origem order by ped.Origem asc");

                }
            }

            double T = 0.0;
            for (int L = 0; L < JTableOrigem.getRowCount(); L++) {
                T += Double.parseDouble(JTableOrigem.getModel().getValueAt(L, 4).toString().replace("R$", "").replace(".", "").replace(",", "."));
                lblTotal1.setText(z.format(T));
            }

        }


    }//GEN-LAST:event_jButton2ActionPerformed

    private void JdcFimPropertyChange(java.beans.PropertyChangeEvent evt) {//GEN-FIRST:event_JdcFimPropertyChange
        try {
            data2 = JdcFim.getDate();
            datafim = fmt.format(data(JdcFim.getDate()));

        } catch (Exception e) {
        }
    }//GEN-LAST:event_JdcFimPropertyChange

    private void JdcInicioPropertyChange(java.beans.PropertyChangeEvent evt) {//GEN-FIRST:event_JdcInicioPropertyChange
        try {
            data1 = JdcInicio.getDate();
            datainicio = fmt.format(datas(JdcInicio.getDate()));

        } catch (Exception e) {
        }
    }//GEN-LAST:event_JdcInicioPropertyChange

    private void formWindowOpened(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowOpened
        Color Roxo = new Color(88, 55, 66);
        Color Laranja = new Color(242, 184, 171);
        JTableOrigem.setSelectionBackground(Roxo);
        JTableOrigem.setSelectionForeground(Laranja);
        JtableProdutos.setSelectionBackground(Roxo);
        JtableProdutos.setSelectionForeground(Laranja);
        JTableInsumos.setSelectionBackground(Roxo);
        JTableInsumos.setSelectionForeground(Laranja);

        timer.start();
        PreencherCombobox();

      
    }//GEN-LAST:event_formWindowOpened

    private void JcomboPedidosActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_JcomboPedidosActionPerformed
        NomeProduto = (String) JcomboPedidos.getSelectedItem().toString().substring(53).replace("</span></html>", "");


    }//GEN-LAST:event_JcomboPedidosActionPerformed

    private void formMouseMoved(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_formMouseMoved
        frmHome.contador = 20;
        contador = 10;
    }//GEN-LAST:event_formMouseMoved

    private void formWindowClosing(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowClosing
        timer.stop();
        frmHome.contador = 10;
        frmHome.binario = 0;
    }//GEN-LAST:event_formWindowClosing

    private void ChkSiteActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_ChkSiteActionPerformed
        if (ChkSite.isSelected()) {
            site = "Site";
        } else {
            site = "";
        }
    }//GEN-LAST:event_ChkSiteActionPerformed

    private void ChkTelefoneActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_ChkTelefoneActionPerformed
        if (ChkTelefone.isSelected()) {
            telefone = "Telefone";
        } else {
            telefone = "";
        }
    }//GEN-LAST:event_ChkTelefoneActionPerformed

    private void ChkLocalActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_ChkLocalActionPerformed
        if (ChkLocal.isSelected()) {
            local = "In loco";
        } else {
            local = "";
        }
    }//GEN-LAST:event_ChkLocalActionPerformed

    private void JtableProdutosMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_JtableProdutosMouseClicked

        int cod = (int) JtableProdutos.getValueAt(JtableProdutos.getSelectedRow(), 0);

        preencherTabelaInsumos("Select Ins.Cod_Insumo, Ins.Nome_Insumo, Medida, Quantidade from Consumo as Con inner join Insumo as Ins on ins.Cod_Insumo "
                + "= Con.CodInsumo inner join Produto as p on p.Cod_Produto = con.CodProduto and Cod_Produto = '" + cod + "' order by Nome_Insumo asc");

    }//GEN-LAST:event_JtableProdutosMouseClicked

    private void JTableOrigemMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_JTableOrigemMouseClicked
        int cod = (int) JTableOrigem.getValueAt(JTableOrigem.getSelectedRow(), 0);

        preencherTabelaInsumos("Select Ins.Cod_Insumo, Ins.Nome_Insumo, Medida, Quantidade from Consumo as Con inner join Insumo as Ins on ins.Cod_Insumo "
                + "= Con.CodInsumo inner join Produto as p on p.Cod_Produto = con.CodProduto and Cod_Produto = '" + cod + "' order by Nome_Insumo asc");

    }//GEN-LAST:event_JTableOrigemMouseClicked
    int contador = 10;

    public void escreva() {
        System.out.println(contador);

    }
    private javax.swing.Timer timer = new javax.swing.Timer(60 * 1000, new java.awt.event.ActionListener() {
        public void actionPerformed(java.awt.event.ActionEvent e) {
            escreva();
            contador--;
            if (contador == 0) {

                try {
                    dispose();
                    timer.stop();
                } catch (Exception ex) {
                    Logger.getLogger(frmInsumos.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        }
    });

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(frmProdutos.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(frmProdutos.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(frmProdutos.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(frmProdutos.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                try {

                    new frmProdutos().setVisible(true);

                } catch (Exception ex) {
                    Logger.getLogger(frmProdutos.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JCheckBox ChkLocal;
    private javax.swing.JCheckBox ChkSite;
    private javax.swing.JCheckBox ChkTelefone;
    private javax.swing.JTable JTableInsumos;
    private javax.swing.JTable JTableOrigem;
    private javax.swing.JComboBox JcomboPedidos;
    private com.toedter.calendar.JDateChooser JdcFim;
    private com.toedter.calendar.JDateChooser JdcInicio;
    private javax.swing.JTable JtableProdutos;
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JScrollPane jScrollPane3;
    private javax.swing.JLabel lblTotal1;
    // End of variables declaration//GEN-END:variables
    String NomeProduto, datainicio, datafim, data;
    Date data1, data2;

    String local, telefone, site;

    public Date datas(Date i) {
        // Método com retorno. Retorna data
        datainicio = fmt.format(i);
        DateFormat df = DateFormat.getDateInstance(DateFormat.LONG, new Locale("pt", "BR"));

        return i;

    }

    public Date data(Date f) {
        // Método com retorno. Retorna data
        datafim = fmt.format(f);
        DateFormat df = DateFormat.getDateInstance(DateFormat.LONG, new Locale("pt", "BR"));

        return f;

    }

    public boolean ValidaDatas() {
        try {

            if ((data1.getDate() - data2.getDate()) > 0) {
                JOptionPane.showMessageDialog(this, "Data inicial maior que a data final, ou data final menor que a inicial");
                return false;
            }

        } catch (Exception e) {
        }

        if (JdcInicio.getDate() == null) {
            JOptionPane.showMessageDialog(this, "Informe a data Inicial");

            return false;
        }
        if (JdcFim.getDate() == null) {
            JOptionPane.showMessageDialog(this, "Informe a data Final");

            return false;
        }

        return true;

    }

    public void PreencherCombobox() {
        connCombo.getCon();
        connCombo.executaSql("select distinct Nome_Produto from Produto as p inner join Detalhe_Pedido as dp on p.Cod_Produto = dp.Cod_Produto order by Nome_Produto");

        try {

            connCombo.rs.first();

            JcomboPedidos.addItem("<html><span style='color:#583742;font-weight: bold;'>Selecione o produto...</span></html>");
            JcomboPedidos.addItem("<html><span style='color:#583742;font-weight: bold;'>Todos</span></html>");
            do {

                JcomboPedidos.addItem("<html><span style='color:#583742;font-weight: bold;'>" + (connCombo.rs.getString("Nome_Produto") + "</span></html>"));

            } while (connCombo.rs.next());

        } catch (Exception e) {
            JOptionPane.showMessageDialog(rootPane, "Erro ao preencher ComboBox");
        }

    }

    public void preencherTabela(String Sql) {
        ArrayList dados = new ArrayList();

        String[] Colunas = new String[]{("<html><span style='color:#ef6f53;font-weight: bold;'>Codigo</span></html>"), (("<html><span style='color:#ef6f53;font-weight: bold;'>Nome do Produto</span></html>")),
            ("<html><span style='color:#ef6f53;font-weight: bold;'>Valor Venda</span></html>"), ("<html><span style='color:#ef6f53;font-weight: bold;'>Data Venda</span></html>"), ("<html><span style='color:#ef6f53;font-weight: bold;'>Origem</span></html>")};

        conecta.executaSql(Sql);
        try {
            conecta.rs.first();
            do {

                dados.add(new Object[]{conecta.rs.getInt("Cod_Produto"), conecta.rs.getString("Nome_Produto"), z.format(conecta.rs.getDouble("Valor_Venda")),
                    fmt.format(conecta.rs.getDate("Data")), conecta.rs.getString("Origem")});

            } while (conecta.rs.next());

        } catch (Exception e) {
            JOptionPane.showMessageDialog(this, "Produto não lançado no intervalo de data escolhido");

        }

        ModeloTabelas modelo = new ModeloTabelas(dados, Colunas); //Instacia a classe do modelo da Tabela.

        JtableProdutos.setModel(modelo);
        JtableProdutos.getColumnModel().getColumn(0).setPreferredWidth(77); // Tamanho em pixel da coluna
        JtableProdutos.getColumnModel().getColumn(0).setResizable(false);
        JtableProdutos.getColumnModel().getColumn(1).setPreferredWidth(109);
        JtableProdutos.getColumnModel().getColumn(1).setResizable(false);
        JtableProdutos.getColumnModel().getColumn(2).setPreferredWidth(90);
        JtableProdutos.getColumnModel().getColumn(2).setResizable(false);
        JtableProdutos.getColumnModel().getColumn(3).setPreferredWidth(97);
        JtableProdutos.getColumnModel().getColumn(3).setResizable(false);
        JtableProdutos.getColumnModel().getColumn(4).setPreferredWidth(120);
        JtableProdutos.getColumnModel().getColumn(4).setResizable(false);
        JtableProdutos.getTableHeader().setReorderingAllowed(false);
        JtableProdutos.setAutoResizeMode(JtableProdutos.AUTO_RESIZE_OFF);//Não pode ser redimensionada
        JtableProdutos.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);

    }

    public void preencherTabelaOrigem(String Sql) {
        ArrayList dados = new ArrayList();
        String[] Colunas = new String[]{("<html><span style='color:#ef6f53;font-weight: bold;'>Codigo</span></html>"), ("<html><span style='color:#ef6f53;font-weight: bold;'>Nome do Produto</span></html>"),
            ("<html><span style='color:#ef6f53;font-weight: bold;'>Valor Venda</span></html>"), ("<html><span style='color:#ef6f53;font-weight: bold;'>Quantidade</span></html>"),
            ("<html><span style='color:#ef6f53;font-weight: bold;'>Total</span></html>"), ("<html><span style='color:#ef6f53;font-weight: bold;'>Origem</span></html>")};

        conecta.executaSql(Sql);
        try {
            conecta.rs.first();
            do {

                dados.add(new Object[]{conecta.rs.getInt("Cod_Produto"), conecta.rs.getString("Nome_Produto"), z.format(conecta.rs.getDouble("Valor_Venda")),
                    conecta.rs.getInt("Quantidade"), z.format(conecta.rs.getDouble("Total")), conecta.rs.getString("Origem")});

            } while (conecta.rs.next());

        } catch (Exception e) {

        }

        ModeloTabelas modelo = new ModeloTabelas(dados, Colunas); //Instacia a classe do modelo da Tabela.
        JTableOrigem.setModel(modelo);
        JTableOrigem.getColumnModel().getColumn(0).setPreferredWidth(55); // Tamanho em pixel da coluna
        JTableOrigem.getColumnModel().getColumn(0).setResizable(false);
        JTableOrigem.getColumnModel().getColumn(1).setPreferredWidth(109);
        JTableOrigem.getColumnModel().getColumn(1).setResizable(false);
        JTableOrigem.getColumnModel().getColumn(2).setPreferredWidth(80);
        JTableOrigem.getColumnModel().getColumn(2).setResizable(false);
        JTableOrigem.getColumnModel().getColumn(3).setPreferredWidth(77);
        JTableOrigem.getColumnModel().getColumn(3).setResizable(false);
        JTableOrigem.getColumnModel().getColumn(4).setPreferredWidth(82);
        JTableOrigem.getColumnModel().getColumn(4).setResizable(false);
        JTableOrigem.getColumnModel().getColumn(5).setPreferredWidth(91);
        JTableOrigem.getColumnModel().getColumn(5).setResizable(false);
        JTableOrigem.getTableHeader().setReorderingAllowed(false);
        JTableOrigem.setAutoResizeMode(JTableOrigem.AUTO_RESIZE_OFF);//Não pode ser redimensionada
        JTableOrigem.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);

    }

    public void preencherTabelaInsumos(String Sql) {

        ArrayList dados = new ArrayList();
        String[] Colunas = new String[]{("<html><span style='color:#ef6f53;font-weight: bold;'>Codigo do Insumo</span></html>"),
            ("<html><span style='color:#ef6f53;font-weight: bold;'>Nome do Insumo</span></html>"),
            ("<html><span style='color:#ef6f53;font-weight: bold;'>Medida</span></html>"),
            ("<html><span style='color:#ef6f53;font-weight: bold;'>Quantidade</span></html>")
        };

        conecta.executaSql(Sql);
        try {
            conecta.rs.first();
            do {
                if (conecta.rs.getString("Medida").equals("Un.")) {
                    dados.add(new Object[]{conecta.rs.getInt("Cod_Insumo"), conecta.rs.getString("Nome_Insumo"), conecta.rs.getString("Medida"), un.format(conecta.rs.getDouble("Quantidade"))});
                } else {
                    dados.add(new Object[]{conecta.rs.getInt("Cod_Insumo"), conecta.rs.getString("Nome_Insumo"), conecta.rs.getString("Medida"), dfs.format(conecta.rs.getDouble("Quantidade"))});

                }
            } while (conecta.rs.next());

        } catch (Exception e) {
            JOptionPane.showMessageDialog(this, "Erro" + e);

        }

        ModeloTabelas modelo = new ModeloTabelas(dados, Colunas); //Instacia a classe do modelo da Tabela.
        JTableInsumos.setModel(modelo);
        JTableInsumos.getColumnModel().getColumn(0).setPreferredWidth(125); // Tamanho em pixel da coluna
        JTableInsumos.getColumnModel().getColumn(0).setResizable(false);
        JTableInsumos.getColumnModel().getColumn(1).setPreferredWidth(185);
        JTableInsumos.getColumnModel().getColumn(1).setResizable(false);
        JTableInsumos.getColumnModel().getColumn(2).setPreferredWidth(85);
        JTableInsumos.getColumnModel().getColumn(2).setResizable(false);
        JTableInsumos.getColumnModel().getColumn(3).setPreferredWidth(99);
        JTableInsumos.getColumnModel().getColumn(3).setResizable(false);
        JTableInsumos.setAutoResizeMode(JTableInsumos.AUTO_RESIZE_OFF);//Não pode ser redimensionada
        JTableInsumos.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);

    }
}