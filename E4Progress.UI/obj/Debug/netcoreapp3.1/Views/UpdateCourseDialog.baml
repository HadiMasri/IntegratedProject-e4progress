   M S B A M L   `   `   `  ����A  =UIUtil, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/$clr-namespace:UIUtil;assembly=UIUtilUIUtil  5   	   C.clr-namespace:UIUtil.Extension;assembly=UIUtilUIUtil.Extension  5      H DE4Progress.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:E4Progress.UI.StringsE4Progress.UI.Strings 5
      ,   &E4Progress.UI.Views.UpdateCourseDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   4	converter$clr-namespace:UIUtil;assembly=UIUtil  5   	   8ext.clr-namespace:UIUtil.Extension;assembly=UIUtil  5      S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59Y	 UPrism.Unity.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/  	 5	      0resx#clr-namespace:E4Progress.UI.Strings  	 5
      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5        E4Progress.UI.Strings.SR   ResourceManager"   UIUtil.Extension.Translation   ResourceManager# Z 5       � Title$ Update Course��5   	   $	��442��6   $
��1022��6,    � AllowsTransparency$
 True��69    � WindowStartupLocation$ CenterScreen=�6S   
������  � 
ResizeMode$ NoResize=�6�    � WindowStyle$
 None=�6�    � 	Resources 5         UIUtil.NewLineConverter   keyNewLineConverter��%   &	          5   
   6%   5      .��5      � 
������ $��	0,0,0,-24q�6$   	 J� Effect	 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      
   
BlurRadius$
 5Q�6      	Direction$ 0Q�6.      RenderingBias$ Quality=�6<      ShadowDepth$ 1Q�6T      Color$
 Gray��6d   .+�5   
   �� $��
21,10,21,0q�6   .+�5      ��  �� CornerRadius$ 2��6   ._�5      � 
�������$	��400��6*   .+�5      � $��	0,0,301,0q�6   .+�5      �� -   5         ��Name$ CursusNametxt��5   N   $��50��6e   $��15(�6q    % !MaterialDesignFloatingHintTextBox#��[ 6   $��231,54,255,296q�6-  )  #MaterialDesignThemes.Wpf.HintAssist   Hint 6�   �� *
CourseName+ �� 	Converter# [   �� Mode$ TwoWay=�6-  �� 5      -   5         ��Name$ OfficeAppCombo��5   w   $��50��6#    �� DisplayMemberPath$
 Name��6^   $��15(�6�     MaterialDesignComboBox#��[ 6�   $��450,54,25,0q�6G  $	��Top=�6\   �� SelectedValue 6/   �� *Office_ApplicationId+ 6�   �� *OfficeApplication+# [  $ TwoWay=�6\  �� 5      -   5        $ GebruikerTaalCombo��5   �   $��50��6#   $ Translation��6T    �� SelectedValuePath$ 
LanguageId��6t   $��15(�6�   #��[ 6�   $��231,128,255,0q�6k  $	��Top=�6�   6/   �� *
LanguageId+ 6�   �� *UserInterfaceLanguage+# [  $ TwoWay=�6�  �� 5      -   5        $��GUIDtxt��5   @    �� 
IsReadOnly$
 True��6"   $��50��64   $��15(�6O   #��[ 6]   $��450,128,25,222q�6   6�   �� *GUID+# [  $ TwoWay=�6  �� 5      -   5        $��InstructieTaalCombo��5   �   $ 
LanguageId��6H   $ Translation��6g   $��50��6�   $��15(�6�   #��[ 6�   $��231,206,255,0q�6h  $	��Top=�6   6#   �� *
LanguageId+ 6�   �� *InstructionLanguage+# [  $ TwoWay=�6  �� 5      -   5         ��Name$ BtnFileUpload��5   !   $��30��68     MaterialDesignFlatButton#��[ 6D   
�������$��552,291,25,0q�6�   $	��Top=�6�   ��6�   �� *Upload+# [  $ TwoWay=�6  �� 5       -   5        $ txtFileName��5    B   $
 True��6"   $��15(�64   $��231,263,132,79q�6W   #��[ 6p    6�   �� *	ImageName+# [  $ TwoWay=��� 5!      -   5        $ btnSaveCourse��5!   !   $��30��6T   #��[ 6`   
�������$��450,343,137,27q�6  ��6�   �� *Update+# [  $ TwoWay=�6  �� 5"      -	   5        $��imagetxt��5"   n   $
��Left=�6"   $��565,165,0,0q�6=   $�� ��6R   $y�Hidden=�6Z    �� TextWrapping$
 Wrap=�6~   $	��Top=�6�   $	��120��6�   �� 5#      -
   5        $ 	btnCancel��5#   !   $��30��64   #��[ 6@   
�������$��565,343,25,27q�6�   ��6�   �� *Cancel+# [  $ TwoWay=�6�   �� 5$      -   5        $��image��5$   ;   $
��Left=�6    $	��145��6H   $��	10,54,0,0q�6U   $	��Top=�6h   $	��167��6�   �� 5%      -   5        $��
imageCombo��5%   /   $��50��6#   $��15(�6p   #��[ 6~   $
��Left=�6"  $��450,206,0,0q�6=  $	��Top=�6R  $	��204��6j   6�   �� *ChoosePhoto+# [  $ TwoWay=�6j  5&      � 5'      $��	679,0,0,0q�6   .+�5(      �� $ 	20 0 0 20��6!   ��5)      �� 5*   "    �� ImageSource$ ../Assets/e4p.jpg��6-    j� Stretch$
 Fill=�6M   5,      5-      5.      5/      50      51      52      