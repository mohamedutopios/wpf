   M S B A M L   `   `   `  ����C  ?todoList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:todoListtodoList  5   	       todoList.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:todoList     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��0.5* �6   �� 5      $
��0.5* �6   �� 5      $��4* �6   �� 5      $��0.75* �6   .+�5   
   �� -   5        $��taskTextBox��5      $��10q�6%   $	��300��61   $��0��6>   �� 5   
   -   5        $��Ajouter��5      $
��10,5q�69   $��1��6G   $	��150��6T   �� 5   
   -   5        $��taskListView��5      $��10,50q�6'   $	��300��66   $��2��6B    �� View 5      �� 5      .P�5      �� $��Tâche��6%    �� Width$	 200��64    �� DisplayMemberBinding 6@   �� *Description+�� 5      $��Statut��6%   $	 100��65    6A   �� *Status+5      5      �� 5   
    �� Orientation$ 
Horizontal=�6   $��3��6.   $��Center=�6;   .+�5      �� -   5        $��Mettre à Jour��5      $
��10,5q�6F   $��5q�6T   �� 5      -   5        $��	Supprimer��5      $
��10,5q�6B   $��5q�6P   5       5!      5"      