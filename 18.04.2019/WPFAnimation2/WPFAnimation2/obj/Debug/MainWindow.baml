   M S B A M L   `   `   `  ����H  DWPFAnimation2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPFAnimation2WPFAnimation2  5   	       WPFAnimation2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPFAnimation2     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 54        path E� IsClosed �� Point �� Size �� SweepDirection��%�   &	        B� 55  
   .��56     E�  . .��57     �� $ 100,200&�6   $ 15,10��6-   $ 	Clockwise=�6:   �� 58     $ 400,50&�6   $	 5,5��6,   59     5:     5;     .��5=     �� .+�5>  
   F� 
���  ��$��2��6   #��[  60    �� Left$ 10��5?     
 �� Top$ 10��6    $y�Visible=�60   A� 5@  
   -   5        $��	myEllipse��5@  `   $ 10��6   $ 10��6#   $��20��63   $��20��6?   
����İ� � Triggers 5A     :� 5B     	 :� RoutedEvent$	 Ellipse.Loaded��6   .[�5C     �� .��5D     �� .��5E     T� 
 �� 
TargetName$
 	myEllipse��67    �� TargetProperty$ (Canvas.Left)�6Z    T� PathGeometry# [  5F  3    g� Duration$ 0:0:5D�6d    g� RepeatBehavior$ Forever��5G  3    T� Source$ X=�6L   T� 5H     $
 	myEllipse��67   $ (Canvas.Top)�6Z   # [  5I  3   $ 0:0:5D�6d   $ Forever��5J  3   $ Y=�6L   5K     5L     5M     5O     5P     5T     