   M S B A M L   `   `   `  ����I  EClothStock_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ClothStock_WPFClothStock_WPF  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      R NClothStock_ClassLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullbFclr-namespace:ClothStock_ClassLibrary;assembly=ClothStock_ClassLibraryClothStock_ClassLibrary 5      "    ClothStock_WPF.ClothFormPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:ClothStock_WPF     5      9System&clr-namespace:System;assembly=mscorlib     5      XmodelFclr-namespace:ClothStock_ClassLibrary;assembly=ClothStock_ClassLibrary     5        N� Title$  ClothFormPage��5       � 	Resources 5         
dataMarkup S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName  dataType  dataFactory��%n  &	        &	 m     &	 �     S� 5   
   $ 	GetValues��60   "  5       5      M� 5      $ model:Markup��6   5      S� 5   
   $ 	GetValues��6.   "  5       5      M� 5      $ model:Types��6   5      S� 5   
   $ 	GetValues��61   "  5       5      M� 5       $ model:ProducingFactory��6   5"      5#      .��5%      �  � RowDefinitions 5&   
   �� 5'      $	��23* �6   �� 5(      $��2* �6   .+�5*   
   �� ���#181735$��0��5+      $��0��6%   .+�5,      �� $!��Название ткани��6   
�������$��Center=�5.      �� 5/      $	��200��50      ��5/      �� *	ClothName+.��50   "   51      �� 52      $��Фабрика��6   
�������$��Center=�54      �� 55      $	��200��57      ��55      ��  �� Source# [  �� SelectedItem 56      �� 	 �� Path$	 ProducingFactory�57      �� 58      $��Тип��6   
�������$��Center=�5:      �� 5;      $	��200��5=      ��5;      �� # [  5<      �� $	 Types�5=      �� 5>      -   5        $��costPerMetre��5?      $��Цена за метр��5>      
�������$��Center=�5A      �� 5B      $	��200��5C      ��5B      �� *CostPerMetre+5C      �� 5D      $��Наценка��6   
�������$��Center=�5F      �� 5G      $	��200��5I      ��5G      �� # [   5H      �� $	 Markup�5I      �� 5J      $%��Дата поступления��6   
�������$��Center=�5L      (  "System.Windows.Controls.DatePicker  5M      $	��200��5N      
   Text
 5M      �� *	CheckDate+5N      �� 5P      $��Right=�6   $��50 -140q�5Q      .+�5R      �� -   5        $��btnOk��5R      $��OK��6'   $	��100��64    
 button#��[ 5T      �� 5U      -   5        $��	btnCancel��5U      $��Cancel��6*   $	��100��6;   #��[ 5W      5X      5Y      �� 5Z   
   
�������$��0,0.4,0,-0.4q�5[   '   $��1��6=   .@�5\      �� -   5         ��Name$ 	statusBar��5\      
���   �$	��635��5^       �� TextAlignment$ Center=�5_      $	��Top=�5`      $��14(�5a      $��Medium"�5b      $��26��6,   5d      5e      5f      