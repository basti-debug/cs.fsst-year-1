   M S B A M L   `   `   `  ����C  ?spice2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ResistorDrawerResistorDrawer  5   	       ResistorDrawer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ResistorDrawer     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �� -   5         ��Name$ controlcanvas��5	      .+�5
   
   �� $��Resistor Drawer��6   $��46��6*    �� Left$ 34��66   
 �� Top$ 22��6G   $	��254��6W   $��Yu Gothic UI Semibold)�6c   $��30(�6�   $
��Bold"�6�   �� 5   
   $��by basti-debug��6   $��27��6)   $ 36��65   $ 56��6F   $��98��6V   $��Yu Gothic UI Semibold)�6a    J� RenderTransformOrigin$ 0.422,0.278&�6�   �� 5   
   $P��Juse the slider to control the width, click on a spot to place the resitor ��6   $��24��6e   $ 36��6q   $ 73��6�   $	��401��6�   $��Yu Gothic UI Semibold)�6�   $ 0.422,0.278&�6�   �� 5   
   -   5        $ drawcan��5      $	��312��6"   $ 10��6/   $ 97��6@   $	��565��6P   |�. 
����� �6�   �� 5   
   $��Choose a part: ��6   $��27��6*   $	 598��66   $ 97��6H   $	��138��6X   �� 5   
   -   5         ��Name$ enteredvalue��5      $��20��6(   $	 598��64    �� TextWrapping$
 Wrap=�6F   $��Value��6Z   $	 211��6g   $��44��6x   6�   	� 5   
   -   5         	�Name$ resistorbutton��5      $��resistor��6.   $	 598��6A   $	 124��6S   6d   	� 5   
   -   5        $ condensatorbutton��5      $��condensator��61   $	 598��6G   $	 144��6Y   6j   	� 5   
   -   5        $ 
coilbutton��5      $
��coil��6*   $	 598��69   $	 164��6K   6\   �� 5   
   -   5         ��Name$ widthslider��5      $	��155��6&   $	 598��62   $	 264��6D   	 � Minimum$	 5Q�6}   
 � Maximum$
 15Q�6�   �� 5   
   $��width of the parts��6   $��28��6-   $	 598��69   $	 231��6K   $	��116��6\   �� 5   
   $��value of the part:��6   $��27��6-   $	 598��69   $	 184��6K   $	��126��6\   5      5      