   M S B A M L   `   `   `  ����F  BWPFSobitiya, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFSobitiyaWPFSobitiya  5   	       WPFSobitiya.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPFSobitiya     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      �� 5      �� 5      .+�5   
   �� $��3��6    �� Orientation$ 
Horizontal=�6)   .+�5      �� -   5        $��Font_8��5      $��Window Font 8��6%   6=   �� 5      -   5        $��Font_11��5      $��240,0,240,0q�6%   $��Window Font 11��6:   6S   �� 5      -   5        $��Font_14��5      $��Window Font 14��6$   6=   5      �� 5   
   -   5        $��1��5      $��3��6"   $ 
Horizontal=�66   $
��0 40q�6O   .+�5      �� -   5        $��Button_8��5      $��Button Font 8��6'   �� 5      -   5        $��	Button_11��5      $��240,0,240,0q�6'   $��Button Font 11��6<   �� 5      -   5        $��	Button_14��5      $��Button Font 14��6&   5        WPFSobitiya.SpaceButton  5    
      WPFSobitiya.SpaceButton   Click$ SpaceButton_Click��6Y   $��2��6   $��0��6)      Text$ Button space 0��69      Space$ 0��6O   6Y     5!   
   $��2��6   $��1��6)   $ Button space 1��69   $ 1��6O     5"   
   $��2��6   $��2��6)   $ Button space 2��69   $ 2��6O     5$   
   $ SpaceWindow_Click��6W   $��3��6   $��0��6)   $ Window space 0��69   
 � Tag$ 0��6O   6W     5%   
   $ SpaceWindow_Click��6W   $��3��6   $��1��6)   $ Window space 1��69   $ 1��6O   6W     5&   
   $ SpaceWindow_Click��6W   $��3��6   $��2��6)   $ Window space 2��69   $ 2��6O   6W   5'      5(      