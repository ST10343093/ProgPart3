   M S B A M L   `   `   `  ����D  @ProgPart3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ProgPart3	ProgPart3  5   	       ProgPart3.AddIngredient   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ProgPart3     5   	     � Title$  AddIngredient��5   	   $	��670��6   $
��1126��6,   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��7* �6   �� 5      $��1081* �6   .+�5   
   �� $
��Left=�6   $	��654��6+   $��Center=�68   $
��1126��6S   $��/1.png��6`   $
��Fill=�6p   $��2��6   �� 5   
   $��1��6   $��Center=�6$   $	��620��6A   $��0,24,0,0q�6N   
���   �$	��Top=�6o   $
��1099��6�   ���	#960000006�   �� 5   
   -   5         ��Name$ AddIngredientLabel��5      $��Add New Ingredient��6,   $
��Left=�6I   $��	10,24,0,0q�6d   $	��Top=�6w   ���	#FFFFEA00$��Arial Black)�6�   $��62(�6�   $��1��6�   �� 5   
   $(��"Enter the name of the  Ingredient:��6   $
��Left=�6=   $��
10,142,0,0q�6X   $	��Top=�6l   
�������$��Arial Black)�6�   $��36(�6�   $��1��6�   ��6�   Z� 6�   �� 5   
   $'��!Enter the quantity of ingredient:��6   $
��Left=�6<   $��
10,225,0,0q�6W   $	��Top=�6k   
�������$��Arial Black)�6�   $��36(�6�   $��1��6�   ��6�   Z� 6�   �� 5   
   $$��Enter the unit of measurement:��6   $
��Left=�69   $��
10,308,0,0q�6T   $	��Top=�6h   
�������$��Arial Black)�6�   $��36(�6�   $��1��6�   ��6�   Z� 6�   �� 5   
   $��Enter the Food Group:��6   $
��Left=�60   $��	3,398,0,0q�6K   $	��Top=�6^   
�������$��Arial Black)�6�   $��36(�6�   $��1��6�   ��6v   Z� 6�   �� 5   
   $ ��Enter the no. of calories:��6   $
��Left=�65   $��
10,480,0,0q�6P   $	��Top=�6d   
�������$��Arial Black)�6�   $��36(�6�   $��1��6�   ��6|   Z� 6�   �� 5   
   -   5         ��Name$ btnAddIngredient��5      $��Add Ingredient��6+   $
��Left=�6D   $��809,563,0,0q�6_   $	��Top=�6t   $��53��6�   $	��232��6�   ���	#FFFFEA00$��Arial Black)�6�   $��22(�6�   ���	#FF060000$��1��6�   6
  �� 5   
   -   5         ��Name$ IngredientNameTextBox��5      $
��Left=�61   $��719,142,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��366��6�   $��51��6�   $��Arial Black)�6�   $��36(�6�   $��1��6�   �� 5   
   -   5        $ Quantitytxt��5      $
��Left=�6'   $��719,226,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��366��6�   $��50��6�   $��Arial Black)�6�   $��36(�6�   $��1��6�   �� 5   
   -   5        $ NumCaloriestxt��5      $
��Left=�6*   $��693,454,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��392��6�   $��51��6�   $��Arial Black)�6�   $��36(�6�   $��1��6�   �� 5   
   -   5         ��Name$ unitComboBox��5      $��1��6)   $
��Left=�69   $��	851,0,0,0q�6T   $��Center=�6g   $	��234��6�   $��44��6�   $��Arial Black)�6�   $��20(�6�   �� 5   
   -   5        $ foodGroupComboBox��5      $��1��6.   $
��Left=�6>   $��851,380,0,0q�6Y   $	��Top=�6n   $	��234��6�   $��44��6�   $��Arial Black)�6�   $��20(�6�   5      5      