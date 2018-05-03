/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Visao;

import Controlador.ControladorDespesa;
import Modelo.ModeloTabelas;
import Modelo.clsDespesa;
import giovanellis.SqlServer;
import java.awt.Color;
import java.util.ArrayList;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.ImageIcon;
import javax.swing.JOptionPane;
import javax.swing.ListSelectionModel;

/**
 *
 * @author Alex
 */
public class frmCadastrarDespesa extends javax.swing.JFrame {

    private final ControladorDespesa DAO;
    private clsDespesa objDespesa;
    private clsDespesa objDespAtua;
    SqlServer conecta;
    public int metodo;
    SqlServer connCombo;

    public frmCadastrarDespesa() throws Exception {
        Color Fundo = new Color(238, 235, 227);
        getContentPane().setBackground(Fundo);
        setAlwaysOnTop(true);
        conecta = new SqlServer();
        connCombo = new SqlServer();
        initComponents();
        this.setIconImage(new ImageIcon(getClass().getResource("/Imagens/Icone.png")).getImage());
        DAO = new ControladorDespesa();
        conecta.getCon();
        rdTodas.setSelected(true);

    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        GrupoCadastro = new javax.swing.ButtonGroup();
        GrupoDespesas = new javax.swing.ButtonGroup();
        jScrollPane2 = new javax.swing.JScrollPane();
        jEditorPane1 = new javax.swing.JEditorPane();
        jLabel5 = new javax.swing.JLabel();
        jScrollPane1 = new javax.swing.JScrollPane();
        JTable = new javax.swing.JTable();
        lblCadastro = new javax.swing.JLabel();
        jLabel1 = new javax.swing.JLabel();
        lblAltera = new javax.swing.JLabel();
        rdAtualizaAtivo = new javax.swing.JRadioButton();
        rdAtualizaInativo = new javax.swing.JRadioButton();
        txtSituação = new javax.swing.JTextField();
        txtCodigoDespesa = new javax.swing.JTextField();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        txt_Novadespesa = new javax.swing.JTextField();
        rdTodas = new javax.swing.JRadioButton();
        rdInativas = new javax.swing.JRadioButton();
        rdAtivas = new javax.swing.JRadioButton();
        btnAlterar = new javax.swing.JButton();
        btnCadastrar = new javax.swing.JButton();
        btnAcao = new javax.swing.JButton();
        jMenuBar1 = new javax.swing.JMenuBar();
        jMenu1 = new javax.swing.JMenu();

        jScrollPane2.setViewportView(jEditorPane1);

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setResizable(false);
        addMouseMotionListener(new java.awt.event.MouseMotionAdapter() {
            public void mouseMoved(java.awt.event.MouseEvent evt) {
                formMouseMoved(evt);
            }
        });
        addWindowListener(new java.awt.event.WindowAdapter() {
            public void windowClosed(java.awt.event.WindowEvent evt) {
                formWindowClosed(evt);
            }
            public void windowClosing(java.awt.event.WindowEvent evt) {
                formWindowClosing(evt);
            }
            public void windowOpened(java.awt.event.WindowEvent evt) {
                formWindowOpened(evt);
            }
        });
        getContentPane().setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jLabel5.setBackground(new java.awt.Color(88, 55, 66));
        jLabel5.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        jLabel5.setForeground(new java.awt.Color(239, 111, 83));
        jLabel5.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel5.setText("Despesas Cadastradas:");
        jLabel5.setOpaque(true);
        getContentPane().add(jLabel5, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 540, 40));

        JTable.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        JTable.setForeground(new java.awt.Color(88, 55, 66));
        JTable.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {},
                {},
                {},
                {}
            },
            new String [] {

            }
        ));
        JTable.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                JTableMouseClicked(evt);
            }
        });
        jScrollPane1.setViewportView(JTable);

        getContentPane().add(jScrollPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 110, 509, 170));

        lblCadastro.setBackground(new java.awt.Color(88, 55, 66));
        lblCadastro.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        lblCadastro.setForeground(new java.awt.Color(239, 111, 83));
        lblCadastro.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblCadastro.setText("Cadastramento de Despesas:");
        lblCadastro.setOpaque(true);
        getContentPane().add(lblCadastro, new org.netbeans.lib.awtextra.AbsoluteConstraints(-17, 302, 560, 30));

        jLabel1.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(88, 55, 66));
        jLabel1.setText("Nome:");
        getContentPane().add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(80, 363, -1, -1));

        lblAltera.setBackground(new java.awt.Color(88, 55, 66));
        lblAltera.setFont(new java.awt.Font("Tahoma", 1, 18)); // NOI18N
        lblAltera.setForeground(new java.awt.Color(239, 111, 83));
        lblAltera.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblAltera.setText("Alteração de Despesa:");
        lblAltera.setOpaque(true);
        getContentPane().add(lblAltera, new org.netbeans.lib.awtextra.AbsoluteConstraints(-9, 302, 550, 30));

        GrupoCadastro.add(rdAtualizaAtivo);
        rdAtualizaAtivo.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        rdAtualizaAtivo.setForeground(new java.awt.Color(88, 55, 66));
        rdAtualizaAtivo.setText("Ativo");
        rdAtualizaAtivo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                rdAtualizaAtivoActionPerformed(evt);
            }
        });
        getContentPane().add(rdAtualizaAtivo, new org.netbeans.lib.awtextra.AbsoluteConstraints(350, 400, -1, -1));

        GrupoCadastro.add(rdAtualizaInativo);
        rdAtualizaInativo.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        rdAtualizaInativo.setForeground(new java.awt.Color(88, 55, 66));
        rdAtualizaInativo.setText("Inativo");
        rdAtualizaInativo.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                rdAtualizaInativoMouseClicked(evt);
            }
        });
        rdAtualizaInativo.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                rdAtualizaInativoActionPerformed(evt);
            }
        });
        getContentPane().add(rdAtualizaInativo, new org.netbeans.lib.awtextra.AbsoluteConstraints(350, 430, -1, -1));

        txtSituação.setEnabled(false);
        getContentPane().add(txtSituação, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 440, 94, -1));

        txtCodigoDespesa.setEnabled(false);
        getContentPane().add(txtCodigoDespesa, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 400, 94, -1));

        jLabel3.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(88, 55, 66));
        jLabel3.setText("Código:");
        getContentPane().add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(80, 403, -1, -1));

        jLabel4.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        jLabel4.setForeground(new java.awt.Color(88, 55, 66));
        jLabel4.setText("Situação:");
        getContentPane().add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(80, 443, -1, -1));
        getContentPane().add(txt_Novadespesa, new org.netbeans.lib.awtextra.AbsoluteConstraints(150, 360, 256, -1));

        GrupoDespesas.add(rdTodas);
        rdTodas.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        rdTodas.setForeground(new java.awt.Color(88, 55, 66));
        rdTodas.setText("Todas");
        rdTodas.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                rdTodasActionPerformed(evt);
            }
        });
        getContentPane().add(rdTodas, new org.netbeans.lib.awtextra.AbsoluteConstraints(161, 69, -1, -1));

        GrupoDespesas.add(rdInativas);
        rdInativas.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        rdInativas.setForeground(new java.awt.Color(88, 55, 66));
        rdInativas.setText("Inativas");
        rdInativas.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                rdInativasActionPerformed(evt);
            }
        });
        getContentPane().add(rdInativas, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 69, -1, -1));

        GrupoDespesas.add(rdAtivas);
        rdAtivas.setFont(new java.awt.Font("Tahoma", 1, 11)); // NOI18N
        rdAtivas.setForeground(new java.awt.Color(88, 55, 66));
        rdAtivas.setText("Ativas");
        rdAtivas.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                rdAtivasActionPerformed(evt);
            }
        });
        rdAtivas.addPropertyChangeListener(new java.beans.PropertyChangeListener() {
            public void propertyChange(java.beans.PropertyChangeEvent evt) {
                rdAtivasPropertyChange(evt);
            }
        });
        getContentPane().add(rdAtivas, new org.netbeans.lib.awtextra.AbsoluteConstraints(88, 69, -1, -1));

        btnAlterar.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnAlterar.setForeground(new java.awt.Color(239, 111, 83));
        btnAlterar.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagens/button.png"))); // NOI18N
        btnAlterar.setText("Alterar");
        btnAlterar.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        btnAlterar.setOpaque(false);
        btnAlterar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAlterarActionPerformed(evt);
            }
        });
        getContentPane().add(btnAlterar, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 530, 100, 40));

        btnCadastrar.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnCadastrar.setForeground(new java.awt.Color(239, 111, 83));
        btnCadastrar.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagens/button.png"))); // NOI18N
        btnCadastrar.setText("Nova");
        btnCadastrar.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        btnCadastrar.setOpaque(false);
        btnCadastrar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnCadastrarActionPerformed(evt);
            }
        });
        getContentPane().add(btnCadastrar, new org.netbeans.lib.awtextra.AbsoluteConstraints(410, 530, 100, 40));

        btnAcao.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        btnAcao.setForeground(new java.awt.Color(239, 111, 83));
        btnAcao.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagens/button.png"))); // NOI18N
        btnAcao.setText("Cadastrar");
        btnAcao.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);
        btnAcao.setOpaque(false);
        btnAcao.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAcaoActionPerformed(evt);
            }
        });
        getContentPane().add(btnAcao, new org.netbeans.lib.awtextra.AbsoluteConstraints(220, 480, 100, 40));

        jMenuBar1.setBackground(new java.awt.Color(239, 111, 83));
        jMenuBar1.setBorder(null);
        jMenuBar1.setForeground(new java.awt.Color(239, 111, 83));
        jMenuBar1.setBorderPainted(false);
        jMenuBar1.setFont(new java.awt.Font("Tahoma", 1, 12)); // NOI18N

        jMenu1.setBackground(new java.awt.Color(88, 55, 66));
        jMenu1.setForeground(new java.awt.Color(88, 55, 66));
        jMenu1.setText("Lançar Despesas");
        jMenu1.setFont(new java.awt.Font("Tahoma", 1, 14)); // NOI18N
        jMenu1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jMenu1MouseClicked(evt);
            }
        });
        jMenuBar1.add(jMenu1);

        setJMenuBar(jMenuBar1);

        setSize(new java.awt.Dimension(534, 634));
        setLocationRelativeTo(null);
    }// </editor-fold>//GEN-END:initComponents

    private void formWindowOpened(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowOpened
        timer.start();
        Color Roxo = new Color(88, 55, 66);
        Color Laranja = new Color(242, 184, 171);
        JTable.setSelectionBackground(Roxo);
        JTable.setSelectionForeground(Laranja);
        lblAltera.setVisible(false);
        rdAtualizaAtivo.setVisible(false);
        rdAtualizaInativo.setVisible(false);
        txt_Novadespesa.requestFocus();
        preencherTabela("Select * from TipoDespesa order by NomeDespesa");
        // CmbDespesa.setVisible(false);

    }//GEN-LAST:event_formWindowOpened

    private void JTableMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_JTableMouseClicked
        try {

            acao = 2;
            int linha_selecionada = JTable.getSelectedRow(); // Pega a linha selecionada.
            txtCodigoDespesa.setText(JTable.getValueAt(linha_selecionada, 0).toString());
            txt_Novadespesa.setText(JTable.getValueAt(linha_selecionada, 1).toString());
            txtSituação.setText(JTable.getValueAt(linha_selecionada, 2).toString());
            btnAcao.setEnabled(true);
            rdAtualizaAtivo.setSelected(true);
            lblCadastro.setVisible(false);
            lblAltera.setVisible(true);
            rdAtualizaAtivo.setVisible(true);
            rdAtualizaInativo.setVisible(true);
            btnAcao.setText("  Alterar  ");
            btnAcao.setEnabled(true);
        } catch (Exception e) {
        }

    }//GEN-LAST:event_JTableMouseClicked

    private void rdAtualizaInativoMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_rdAtualizaInativoMouseClicked
        txtSituação.setText("Inativo");

    }//GEN-LAST:event_rdAtualizaInativoMouseClicked

    private void rdTodasActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_rdTodasActionPerformed
        preencherTabela("Select * from TipoDespesa order by NomeDespesa asc");

    }//GEN-LAST:event_rdTodasActionPerformed

    private void rdInativasActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_rdInativasActionPerformed
        preencherTabela("Select * from TipoDespesa where SituacaoDespesa = 'Inativo' order by NomeDespesa asc");


    }//GEN-LAST:event_rdInativasActionPerformed

    private void rdAtivasActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_rdAtivasActionPerformed
        preencherTabela("Select * from TipoDespesa where SituacaoDespesa = 'Ativo' order by NomeDespesa asc");

    }//GEN-LAST:event_rdAtivasActionPerformed

    private void btnAlterarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAlterarActionPerformed
        preencherTabela("Select * from TipoDespesa order by NomeDespesa asc");
        lblCadastro.setVisible(false);
        lblAltera.setVisible(true);
        rdTodas.setSelected(true);
        rdAtualizaAtivo.setVisible(true);
        rdAtualizaInativo.setVisible(true);
        btnAcao.setText("  Alterar  ");
        acao = 2;
        btnAcao.setVisible(true);
        if (acao == 2) {
            btnAcao.setEnabled(false);
        }


    }//GEN-LAST:event_btnAlterarActionPerformed

    private void btnCadastrarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnCadastrarActionPerformed

        preencherTabela("Select * from TipoDespesa where SituacaoDespesa = 'Ativo' order by NomeDespesa asc");
        acao = 1;
        rdAtivas.setSelected(true);
        LimpaCampos();
        lblAltera.setVisible(false);
        rdAtualizaAtivo.setVisible(false);
        rdAtualizaInativo.setVisible(false);
        txt_Novadespesa.requestFocus();
        lblCadastro.setVisible(true);
        btnAcao.setText("Cadastrar");
        btnAcao.setVisible(true);
        if (acao == 1) {
            btnAcao.setEnabled(true);
        }


    }//GEN-LAST:event_btnCadastrarActionPerformed

    private void rdAtualizaAtivoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_rdAtualizaAtivoActionPerformed
        txtSituação.setText("Ativo");
    }//GEN-LAST:event_rdAtualizaAtivoActionPerformed

    private void rdAtualizaInativoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_rdAtualizaInativoActionPerformed
        txtSituação.setText("Inativo");
    }//GEN-LAST:event_rdAtualizaInativoActionPerformed

    private void btnAcaoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAcaoActionPerformed
        if (acao == 1) {

            try {

                if (validarCampos()) {

                    if (PreencherObjeto()) {
                        if (DAO.Incluir(objDespesa)) {

                            JOptionPane.showMessageDialog(this, "Dados salvos com Sucesso");
                            rdAtivas.setSelected(true);
                            txtCodigoDespesa.setText("");
                            preencherTabela("Select * from TipoDespesa where SituacaoDespesa = 'Ativo' order by NomeDespesa asc");

                        }
                    } else {
                        JOptionPane.showMessageDialog(this, "Não foi possivel inserir os Dados");
                    }

                }

            } catch (Exception erro) {
                JOptionPane.showMessageDialog(this, "Erro" + erro.getMessage());
            }

            LimpaCampos();
        } else {

            try {

                if (validarCampos()) {

                    if (PreencherObjetoUp()) {
                        if (DAO.Editar(objDespesa)) {

                            if (rdAtualizaAtivo.isSelected()) {
                                JOptionPane.showMessageDialog(this, "Dados atualizados com Sucesso");
                                preencherTabela("Select * from TipoDespesa where SituacaoDespesa = 'Ativo' order by NomeDespesa");

                                btnAcao.setEnabled(false);
                                rdAtivas.setSelected(true);
                                rdAtualizaAtivo.setSelected(false);
                                rdAtualizaInativo.setSelected(false);

                            } else {
                                JOptionPane.showMessageDialog(this, "Dados atualizados com Sucesso");
                                preencherTabela("Select * from TipoDespesa where SituacaoDespesa = 'Inativo' order by NomeDespesa");

                                btnAcao.setEnabled(false);
                                rdInativas.setSelected(true);
                                rdAtualizaAtivo.setSelected(false);
                                rdAtualizaInativo.setSelected(false);

                            }

                        }
                    } else {
                        JOptionPane.showMessageDialog(this, "Não foi possivel atualizar os Dados");
                        btnAcao.setEnabled(false);
                    }
                }

            } catch (Exception erro) {
                JOptionPane.showMessageDialog(this, "Erro" + erro.getMessage());
            }

            LimpaCampos();

        }
    }//GEN-LAST:event_btnAcaoActionPerformed

    private void rdAtivasPropertyChange(java.beans.PropertyChangeEvent evt) {//GEN-FIRST:event_rdAtivasPropertyChange
        // TODO add your handling code here:
    }//GEN-LAST:event_rdAtivasPropertyChange

    private void jMenu1MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jMenu1MouseClicked
        try {
            frmDespesas despesas = new frmDespesas();
            despesas.show();
        } catch (Exception ex) {
            Logger.getLogger(frmCadastrarDespesa.class.getName()).log(Level.SEVERE, null, ex);
        }
        dispose();
    }//GEN-LAST:event_jMenu1MouseClicked

    private void formMouseMoved(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_formMouseMoved
        frmHome.contador = 20;
        contador = 10;
    }//GEN-LAST:event_formMouseMoved

    private void formWindowClosing(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowClosing
        timer.stop();
        frmHome.contador = 10;
        frmHome.binario = 0;

    }//GEN-LAST:event_formWindowClosing

    private void formWindowClosed(java.awt.event.WindowEvent evt) {//GEN-FIRST:event_formWindowClosed
        // TODO add your handling code here:
    }//GEN-LAST:event_formWindowClosed
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
            java.util.logging.Logger.getLogger(frmCadastrarDespesa.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(frmCadastrarDespesa.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(frmCadastrarDespesa.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(frmCadastrarDespesa.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                try {
                    new frmCadastrarDespesa().setVisible(true);
                } catch (Exception ex) {
                    Logger.getLogger(frmCadastrarDespesa.class.getName()).log(Level.SEVERE, null, ex);
                }
            }
        });
    }
    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.ButtonGroup GrupoCadastro;
    private javax.swing.ButtonGroup GrupoDespesas;
    private javax.swing.JTable JTable;
    private javax.swing.JButton btnAcao;
    private javax.swing.JButton btnAlterar;
    private javax.swing.JButton btnCadastrar;
    private javax.swing.JEditorPane jEditorPane1;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JMenu jMenu1;
    private javax.swing.JMenuBar jMenuBar1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JLabel lblAltera;
    private javax.swing.JLabel lblCadastro;
    private javax.swing.JRadioButton rdAtivas;
    private javax.swing.JRadioButton rdAtualizaAtivo;
    private javax.swing.JRadioButton rdAtualizaInativo;
    private javax.swing.JRadioButton rdInativas;
    private javax.swing.JRadioButton rdTodas;
    private javax.swing.JTextField txtCodigoDespesa;
    private javax.swing.JTextField txtSituação;
    private javax.swing.JTextField txt_Novadespesa;
    // End of variables declaration//GEN-END:variables
    int acao = 1;

    public void LimpaCampos() {
        txtCodigoDespesa.setText("");
        txtSituação.setText("");
        txt_Novadespesa.setText("");
        rdAtualizaAtivo.setSelected(false);
        rdAtualizaInativo.setSelected(false);

    }

    public boolean validarCampos() {
        if (txt_Novadespesa.getText().equals("")) {
            JOptionPane.showMessageDialog(this, "Preencha o campo Despesa");
            txt_Novadespesa.requestFocus();
            return false;
        }

        return true;

    }

    public boolean PreencherObjeto() {
        objDespesa = new clsDespesa();
        objDespesa.setNomeDespesa(txt_Novadespesa.getText());

        return true;
    }

    public boolean PreencherObjetoUp() {
        objDespesa = new clsDespesa();
        objDespesa.setNomeDespesa(txt_Novadespesa.getText());
        objDespesa.setCodDespesa(Integer.parseInt(txtCodigoDespesa.getText()));// Código para pegar Inteiros.
        objDespesa.setSituacaoDespesa(txtSituação.getText());

        return true;
    }

    public boolean UpdateObjeto() {
        objDespesa = new clsDespesa();
        objDespesa.setNomeDespesa(txt_Novadespesa.getText());

        return true;
    }

    public void preencherTabela(String Sql) {
        ArrayList dados = new ArrayList();
        String[] Colunas = new String[]{"<html><span style='color:#ef6f53;font-weight: bold;'>Código</span></html>",
            "<html><span style='color:#ef6f53;font-weight: bold;'>Nome da Despesa</span></html>",
            "<html><span style='color:#ef6f53;font-weight: bold;'>Situação</span></html>"};

        conecta.executaSql(Sql);
        try {
            conecta.rs.first();
            do {
                dados.add(new Object[]{conecta.rs.getInt("codTipoDespesa"), conecta.rs.getString("NomeDespesa"), conecta.rs.getString("SituacaoDespesa")});
            } while (conecta.rs.next());
        } catch (Exception e) {
            JOptionPane.showMessageDialog(this, "Erro ao preencher o ArrayList");

        }

        ModeloTabelas modelo = new ModeloTabelas(dados, Colunas); //Instacia a classe do modelo da Tabela.
        JTable.setModel(modelo);
        JTable.getColumnModel().getColumn(0).setPreferredWidth(80); // Tamanho em pixel da coluna
        JTable.getColumnModel().getColumn(0).setResizable(false);
        JTable.getColumnModel().getColumn(1).setPreferredWidth(299);
        JTable.getColumnModel().getColumn(1).setResizable(false);
        JTable.getColumnModel().getColumn(2).setPreferredWidth(123);
        JTable.getColumnModel().getColumn(2).setResizable(false);
        JTable.getTableHeader().setReorderingAllowed(false);
        JTable.setAutoResizeMode(JTable.AUTO_RESIZE_OFF);//Não pode ser redimensionada
        JTable.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);

    }

    public clsDespesa getDespesa() {
        clsDespesa Desp = new clsDespesa();
        if (!(txt_Novadespesa.getText().equals(""))) {
            Desp.setCodDespesa(Integer.parseInt(txtCodigoDespesa.getText()));
        }
        Desp.setNomeDespesa(txt_Novadespesa.getText());
        Desp.setSituacaoDespesa(txtSituação.getText());

        return Desp;
    }
}