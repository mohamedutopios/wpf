   M S B A M L   `   `   `  ����>  :tp6, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:tp6tp6  5   	       tp6.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   '	converterclr-namespace:tp6     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	      "   tp6.EmailValidationConverter   EmailValidationConverter  InputFieldStyle �� 
TargetType �� Property �� Value  EmailTextBoxStyle �� BasedOn��%�   &	        &	      &	 �     7    5
   
   6-   �� 5   
   " ��6(   .�5      ��  � ��$	 300��6&   �� 5       � ��$	 0,5q�6'   5      �� 5   
   " ��6*   8   5      5      .��5      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $
��Nom:��6   �� 5   
   -   5         ��Name$ nameTextBox��5      $��1��6'   #��[ 64   �� 5!   
   $��2��6   $��Email:��6   �� 5"   
   -   5        $ emailTextBox��5"      $��3��6(   #��[ 65   �� 5$   
   -   5         ��Name$ submitButton��5$      $��4��6'   $	��150��64   $
��0,10q�6@   $��	Soumettre��6N   6b   �� 5%   
   -   5        	 ��Name$	 validationLabel��5%      $��5��6)   
���  ��$��Center=�6G   5&      5'      