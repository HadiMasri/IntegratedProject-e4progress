   M S B A M L   `   `   `  ����A  =UIUtil, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/$clr-namespace:UIUtil;assembly=UIUtilUIUtil  5   	   C.clr-namespace:UIUtil.Extension;assembly=UIUtilUIUtil.Extension  5      H DE4Progress.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:E4Progress.UI.StringsE4Progress.UI.Strings 5
      %   E4Progress.UI.Views.RolesDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   4	converter$clr-namespace:UIUtil;assembly=UIUtil  5   	   8ext.clr-namespace:UIUtil.Extension;assembly=UIUtil  5      S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59Y	 UPrism.Unity.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/  	 5	      0resx#clr-namespace:E4Progress.UI.Strings  	 5
      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5        E4Progress.UI.Strings.SR   ResourceManager"   UIUtil.Extension.Translation   ResourceManager# Z 5       � Title$ RolesDialog��5   	   $	��593��6   $
��1127��6*    � AllowsTransparency$
 True��67    � WindowStartupLocation$ CenterScreen=�6Q   
������  � 
ResizeMode$ NoResize=�6�    � WindowStyle$
 None=�6�    � 	Resources 5         UIUtil.NewLineConverter   keyNewLineConverter��%   &	          5   
   6%   5      .��5      � 	 J� Effect	 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      
   
BlurRadius$
 5Q�6      	Direction$ 0Q�6.      RenderingBias$ Quality=�6<      ShadowDepth$ 1Q�6T      Color$
 Gray��6d   .+�5   
   � 
�������$��124,106,140,110q�6"   .+�5      �� .+�5      �� $	��378��6   ._�5      � .+�5      � $��	0,0,309,0q�6   .+�5      � .+�5   "   �� -   5         ��Name$ txtUser��5   ,   $��10,6,243,330q�6=   �� 5   "   -   5          MaterialDesignFlatButton#��[ 5   )   
�������$��476,10,10,336q�6�   ��6r   �� *Close+ �� 	Converter# [   �� Mode$ TwoWay=�6�   �� 5   "   -   5        $��cmbRoles��5   +    �� DisplayMemberPath$
 Name��6;    �� SelectedValuePath$ Id��6T   $��33��6k   $��15(�6w     MaterialDesignComboBox#��[ 6�   $��10,64,243,0q�6"  $	��Top=�67  )  #MaterialDesignThemes.Wpf.HintAssist   Hint 6�   �� *Role+# [  $ TwoWay=�67  �� 5    "   -   5         ��Name$ btnasign��5    )   #��[ 6;   
�������$��316,64,144,282q�6�   ��6�   �� *Assign+# [  $ TwoWay=�6�   �� 5!   "   -   5        $ 
txtMessage��5!   ,   $��10,102,144,235q�6@   �� 5"   "   -   5        $ Header��5"   ,    �� TextAlignment$
 Left=�6�   $��17(�6�   $��10,145,407,208q�6�   $��	Underline{�6�   ��6<   �� *ActiveRoles+# [  $ TwoWay=�6�   &   System.Windows.Controls.DataGrid  5$   "   -   5          Name$ lstActiveRole��5$   +   $��10,175,46,26q�6B      AutoGenerateColumns$ False��6X      
IsReadOnly$
 True��6t      SelectionMode$ Single=�6�      SelectionUnit$ FullRow=�6�   $��14(�6�   
���   �   Columns 5%   &   1  +MaterialDesignThemes.Wpf.DataGridTextColumn  5&   *   ,	  &System.Windows.Controls.DataGridColumn 	  Width5
  /System.Windows.Controls.DataGridLengthConverter$	 190
 6L   $ Center=�6X    	  Header$ RoleId��6y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6�   �� *Id+  5'   *   $	 190
 6L   $ Center=�6X   $
 Role��6y    6�   �� *Name+  � ContextMenu  5*   &   �� 5+   *   .@�5,   .   m� -   5        $��End role��5,   7   ! m� Icon! 5-   2   �� 5.   6   $��../Assets/delete.png��6<   50   /   51   +   53   #   54      55      � 57      $��	554,0,0,0q�6   .+�58      �� " �� CornerRadius$" 	20 0 0 20��6%   ��59   "   �� 5:   &   # �� ImageSource$# ../Assets/e4p.jpg��61   $ j� Stretch$
$ Fill=�6Q   5<      5=      5>      5?      5@      5B      5C      5D      