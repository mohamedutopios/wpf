   M S B A M L   `   `   `  ����F  BTriggerDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TriggerDemoTriggerDemo  5   	       TriggerDemo.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:TriggerDemo     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	       �� 
TargetType �� Triggers ]� 
Conditions �� Property �� Value �� Property �� Value��%  '��       �� 5
   
   " ��6    5      ]� 5       5      �� 5       � ��$ Hello��64   �� 5       � {�$ False��69   /�5      �� 5       � ��
 �  ��67   �� 5       � ��
 � ���67   5      5      5      .��5      � .+�5   
   �� .+�5      �� -   5        	 ��Name$	 textBox��5      $��20(�6'   $
��Left=�5      $
��Auto��61   $	��150��6?   $��168,146,0,0q�5      
 �� TextWrapping$

 Wrap=�6+   $��TextBox��6?   $	��Top=�6N   {�5      ��  �� ElementName$ 
chkEnabled�� �� Path$ 	IsChecked��� 5      -   5         ��Name$ 
chkEnabled��5      $��Enable text Box��6+   $��Center=�6E   $��10q�6b   5       5!      5"      