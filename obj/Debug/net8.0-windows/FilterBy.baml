   M S B A M L   `   `   `  ����D  @ProgPart3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:ProgPart3	ProgPart3  5   	       ProgPart3.FilterBy   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:ProgPart3     5   	     � Title$  FilterBy��5   	   $	��753��6   $
��1172��6'   .��5	      � .+�5
   
   �� $��Center=�6   $	��737��6-   $��Center=�6:   $
��1172��6U   $��/1.png��6b   $
��Fill=�6r   �� 5   
   $��Center=�6   $	��647��61   
���   �$��Center=�6M   $
��1112��6h   ���	#AD0000006u   �� 5   
   $��Filter Recipe��6   $
��Left=�6(   $��
373,10,0,0q�6C   $	��Top=�6W   ���	#FFFFEA00$��Arial Black)�6�   $��62(�6�   �� 5   
   -   5         ��Name$ NameFilterBtn��5      $��Name of Ingredient��6(   $
��Left=�6E   $��
46,115,0,0q�6`   $	��Top=�6t   $��53��6�   $	��275��6�   ���	#FFFFEA00$��Arial Black)�6�   $��22(�6�   ���	#FF0600006�   �� 5   
   -   5        $ FoodGroupFilterBtn��5      $��
Food Group��6-   $
��Left=�6B   $��
47,266,0,0q�6]   $	��Top=�6q   $��53��6�   $	��275��6�   ���	#FFFFEA00$��Arial Black)�6�   $��22(�6�   ���	#FF0600006�   �� 5   
   -   5        $ CaloriesFilterBtn��5      $��Calories��6,   $
��Left=�6?   $��
47,432,0,0q�6Z   $	��Top=�6n   $��53��6�   $	��276��6�   ���	#FFFFEA00$��Arial Black)�6�   $��22(�6�   ���	#FF0600006�   �� 5   
   -   5        $ ApplyFilterBtn��5      $��Apply��6)   $
��Left=�69   $��
68,606,0,0q�6T   $	��Top=�6h   $��53��6�   $	��232��6�   ���	#FFF100FF$��Arial Black)�6�   $��22(�6�   ���	#FF0600006�   �� 5   
   -   5         ��Name$ 
lbxRecipes��5      $��373,119,56,153q�6Q   
���   ����	#FFACB3AB$��Arial Black)�6�   $��20(�6�   
�������6�   �� 5   
   -   5        $ ViewRecipeBtn��5      $��View Selected Recipe��6(   $��Center=�6G   $��	0,614,0,0q�6d   $	��Top=�6w   $��53��6�   $	��317��6�   ���	#FF2BFF00$��Arial Black)�6�   $��22(�6�   ���	#FF0600006�   �� 5   
   -   5        $ MainMenuBtn��5      $��	Main Menu��6&   $
��Left=�6:   $��796,614,0,0q�6U   $	��Top=�6j   $��53��6�   $	��320��6�   ���	#FFFF2F00$��Arial Black)�6�   $��22(�6�   ���	#FF0600006�   �� 5   
   -   5         ��Name$ NameTxt��5      $
��Left=�6#   $��
78,200,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $	��Top=�6f   $	��222��6~   $��27��6�   $$��Bahnschrift SemiBold Condensed)�6�   $��18(�6�   $y�Hidden=�6�   �� 5   
   -	   5         ��Name$ cmbGroup��5      $
��Left=�6%   $��74,0,0,0q�6@   $��Center=�6R   $	��222��6m   $��27��6y   $$��Bahnschrift SemiBold Condensed)�6�   $��18(�6�   $y�Hidden=�6�   �� 5   
   -
   5        $ CaloriesTxt��5      $
��Left=�6'   $��
68,514,0,0q�6B   $
 Wrap=�6V   $	��Top=�6j   $	��222��6�   $��29��6�   $$��Bahnschrift SemiBold Condensed)�6�   $��22(�6�   $y�Hidden=�6�   5      5      