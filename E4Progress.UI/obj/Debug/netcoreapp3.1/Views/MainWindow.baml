   M S B A M L   `   `   `  ����A  =UIUtil, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/$clr-namespace:UIUtil;assembly=UIUtilUIUtil  5   	   C.clr-namespace:UIUtil.Extension;assembly=UIUtilUIUtil.Extension  5   	   H DE4Progress.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:E4Progress.UI.StringsE4Progress.UI.Strings 5
   	   $   E4Progress.UI.Views.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   :	converter$clr-namespace:UIUtil;assembly=UIUtil     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   >ext.clr-namespace:UIUtil.Extension;assembly=UIUtil     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59Y	 UPrism.Unity.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/  	 5	   	   0resx#clr-namespace:E4Progress.UI.Strings  	 5
   	   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5   	     E4Progress.UI.Strings.SR   ResourceManager"   UIUtil.Extension.Translation   ResourceManager# Z 5   	    � Title$ 
MainWindow��5   	   $	��800��6   $
��1270��6,    � 
ResizeMode$ 	CanResize=�6<    � WindowStartupLocation$ CenterScreen=�6T    � WindowStyle$
 None=�6y   
������� � 	Resources 5         UIUtil.NewLineConverter   keyNewLineConverter  tb_mouse_over �� ImageSource  tb_mouse_click  
font_style	 �� 
TargetType
 �� Property �� Value  tt_style  tb_style �� 
TargetType ��Name J� SnapsToDevicePixels �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	      &	 L     &	 �     &	 �    &	 3    7  7  7  7    5   
   6%   �� 5   
   $! ../Assets/tgBtn_default.png��5      �� 5   
   $ ../Assets/closeMenu.png��5      �� 5   
   "	 ��6#   .�5      �� 
 � ��$$ Fonts/Roboto-Light.ttf #Roboto)�5      �� 5      
 � ��$ Center=�5      �� 5       
 � ��$
 Left=�5!      �� 5#      
 � ��
 �����5$      �� 5&      
 � ��$ 20(�5'      5)      �� 5-   
   "	 _�6   .�5/      �� 
 �@_�	Placement$ Right=�6*   �� 50      
 � ��$ 40��6'   �� 51      
 � ��$	 100��6&   �� 52      
 � ��$ 20,0,0,0q�6'   �� 53      
 � �� �#4A56686+   �� 54      
 � ��
 ���� 6,   �� 55      
 � ��
 �����6+   �� 56      
 � ��$$ Fonts/Roboto-Light.ttf #Roboto)�6+   �� 57      
 � ��$ 16(�6)   �� 58      
 �@_�PlacementRectangle$ 60,0,0,0�63   �� 59      
 �@_�HorizontalOffset$ 15��61   �� 5:      
 �@_�VerticalOffset$ 6��6/   �� 5;      
 �@_�HasDropShadow$
 True��6.   �� 5<      
 � ��$ Center=�6;   5>      �� 5@   
   "	 d�6!   .�5B      �� 
 � �� 5D      �� 5F      " d�6&   .R�5H      �� $ border��6"   #��z��5I   "   #��z��5J   "   $
 True��5K   "   5M       5O      P� 5Q       �@J�IsMouseOver$
 true��6=   . �5S   "   �� $ border��5T   )   8   
 � ��5U   )   �� 5W   "   $ border��5X   )   8  
 � ��5Y   )   5[      P� 5]       �@d�	IsChecked$
 trueY�6;   . �5_   "   �� $ border��5`   )   8  
 � ��5a   )   �� 5c   "   $ border��5d   )   8  
 � ��5e   )   5g      5k      5o      5q      5s      .��5u      � -   5        ���#FFF.+�5w   
   � .+�5z      � -   5         �Name$ 	headerBar��5z      ���#2E333A$	��Top=�6;   $
��auto��6T   .+�5{      ��  �� Orientation$ 
Horizontal=�6   $��Right=�66   .+�5|      �� -   5         ��Name$ btnShutdown��5|      $��../Assets/shutdown.png��61   $��20��6S   6b   5}      5~      � 5�       � ColumnDefinitions 5�      �� 5�      $
��auto �6'   66   �� 5�      $��1* �6'   64   .+�5�      � -   5        $ 	MainPanel��5�      $��Stretch=�6l   $��Stretch=�6�   $��20q�6�   $y�Hidden=�6�   5�      � 5�      -   5        $ nav_pnl��5�   (   $��0��6   $
��Left=�5�       K� ZIndex$
 1000��5�      ���#2E333A$��65��5�   *   .+�5�      �� -   5         ��Name$ st_pnl��5�   !   .+�5�      � $	��111��6   .+�5�      �� $��1��6)   $��0��5�   %   $��
73,-20,0,0q�5�   %   $��M E N U��5�   %   
�������$��22(�5�   %   
������ $
��Left=�5�   %   $��Center=�5�   %   #��[ 5�   %    J� Effect 5�   "   3  -System.Windows.Media.Effects.DropShadowEffect  5�   &      
BlurRadius$ 10Q�68      ShadowDepth$ 1Q�5�   4      	Direction$	 -90Q�5�   4      Color$ White��5�   4   5�      d� 5�      -   5         d�Name$ Tg_Btn��5�   +   $��0��5�   '   $��Center=�5�   '   $
��Left=�5�   '   $��
18,-20,0,0q�5�   '   $��25��5�   '   $��25��5�   '   $��0q�5�   '   #��[ 5�   '   ��5�   "   �� 5�   &   $! ../Assets/tgBtn_default.png��61    j� Stretch$
 None=�5�   -     � Triggers  5�   "   :� 5�   &   ! :� RoutedEvent$! ToggleButton.Unchecked��63   .[�5�   *   �� .��5�   .   �� -   5        " ��Name$" HideStackPanel��5�   9   .��5�   2   W� # �� 
TargetName$# nav_pnl��5�   1   $ �� TargetProperty$$ Width�5�   1   % g� 	BeginTime	% 0:0:05�   1   & W� From& 2305�   1   	' W� To' 656<   ( g� Duration$( 0:0:0.2D�5�   1   5�   3   5�   /   5�   +   5�   '   :� 5�   &   $! ToggleButton.Checked��63   .[�5�   *   �� .��5�   .   �� -	   5        $" ShowStackPanel��5�   9   .��5�   2   W� $# nav_pnl��5�   1   $$ Width�5�   1   	% 0:0:05�   1   & 655�   1   ' 2306;   $( 0:0:0.3D�5�   1   5�   3   5�   /   5�   +   5�   '   5�      5�      � 5�      $��58��6   .+�5�      '  !MaterialDesignThemes.Wpf.PackIcon  )   Kind$) FaceProfile=�66   $��30��6I   $��40��6U   
�������$��10,0,0,0q�6s   �� 5      -
   5        * ��Name$* txtUserName��5   (   $��70,2,-227,0q�6=   $��17(�6R   
�������6`   5     �� 5     $��Disabled=�6'   $��Hidden=�6P   $
��auto��6u   .��5     �� -   5        $
 Menu��5  )   $��10q�67   5     � 5     $��58��6   .+�5       -   5        $) Logout=�5  6   $��30��6D   $��40��6P   
�������$��10,0,0,0q�6n   6�   5     5     5     �� 5     -   5        $ StackPanelMain��5  .   $��1��6   $��Stretch=�6F   $��Stretch=�6d   $��20q�6�   5     5     5     5     