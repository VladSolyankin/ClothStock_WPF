   M S B A M L   `   `   `  ����I  EClothStock_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ClothStock_WPFClothStock_WPF  5      "    ClothStock_WPF.ClothListPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:ClothStock_WPF     5        N� Title$  ClothListPage��5	      .��5      � .+�5   
   �� 
�������.+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
clothStock��5         CanUserAddRows .     CanUserResizeColumns .     CanUserResizeRows .     CanUserDeleteRows .     CanUserReorderColumns .     
IsReadOnly .    AutoGenerateColumns .  $	��203��5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
 
Ткань��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ 8* 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *	ClothName+6V     5      $
 Фабрика��6)   $ 7* 6V    6:   �� *	Factory+6V     5      $
 Тип ткани��6)   $ 6* 6Z    6<   �� *	ClothType+6Z     5      $
 Цена (м.)��6)   $ 5* 6]    6<   �� *CostPerMetre+6]     5      $
 Дата��6)   $ 6* 6U    67   �� *	CheckDate+6U     5      $
 В наличии��6)   $ 6* 6^    6<   �� *MetresInStock+6^     5      $
 Наценка��6)   $ 5* 6U    6:   �� *Markup+6U   4  .System.Windows.Controls.DataGridTemplateColumn  5         CellTemplate 5      �� 5      .R�5    "   �� $��EditProduct��6<   -   5        $��Изменить��5    )   5!   )   5#      5%      5'      �� 5)      $	��425��6   .+�5*      �� -   5        $��
AddProduct��5*      $	��100��5+      $��Bottom=�5,      $��25��5-      $��Add product��5/       
  button#��[  50      51      �� 53      -   5        $��DeleteProduct��53      $��Delete product��54      $��Bottom=�55      $	��100��56      $��25��57      $"��Applications/Fonts/Dosis.ttf)�59      #��[  5:      5;      5<      5=      5>      