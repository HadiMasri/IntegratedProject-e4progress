   M S B A M L   `   `   `  ����A  =UIUtil, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/$clr-namespace:UIUtil;assembly=UIUtilUIUtil  5   	   C.clr-namespace:UIUtil.Extension;assembly=UIUtilUIUtil.Extension  5      H DE4Progress.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:E4Progress.UI.StringsE4Progress.UI.Strings 5
      )   #E4Progress.UI.Views.NewCourseDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   4	converter$clr-namespace:UIUtil;assembly=UIUtil  5   	   8ext.clr-namespace:UIUtil.Extension;assembly=UIUtil  5      S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59Y	 UPrism.Unity.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/  	 5	      0resx#clr-namespace:E4Progress.UI.Strings  	 5
      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5        E4Progress.UI.Strings.SR   ResourceManager"   UIUtil.Extension.Translation   ResourceManager# Z 5       � Title$ NewCourseDialog��5   	   $	��400��6!   $	��829��6.    � AllowsTransparency$
 True��6:    � WindowStartupLocation$ CenterScreen=�6T   
������  � 
ResizeMode$ NoResize=�6�    � WindowStyle$
 None=�6�    � 	Resources 5         UIUtil.NewLineConverter   keyNewLineConverter��%   &	          5   
   6%   5      .��5      � 
������ $��	0,26,0,38q�6$   	 J� Effect	 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      
   
BlurRadius$
 5Q�6      	Direction$ 0Q�6.      RenderingBias$ Quality=�6<      ShadowDepth$ 1Q�6T      Color$
 Gray��6d   .+�5   
   �� $��21,0,21,-19q�6   .+�5      ��  �� CornerRadius$ 2��6   $	��332��6&   ._�5      � 
�������$��0,0,0,20q�6*   .+�5      � $��	0,0,296,0q�6   .+�5      �� -   5         ��Name$ Header��5   $    �� TextAlignment$ Center=�6�   $��25(�6�   $��	0,0,0,271q�6�   ��64   �� *CreateNewCourse+ �� 	Converter# [   �� Mode$ TwoWay=�6�   �� 5      -   5         ��Name$ CursusNametxt��5   N   $��50��6e   $��15(�6q    % !MaterialDesignFloatingHintTextBox#��[ 6   $��10,46,284,216q�6-  )  #MaterialDesignThemes.Wpf.HintAssist   Hint 6�   �� *
CourseName+# [  $ TwoWay=�6-  �� 5      -   5         ��Name$ OfficeAppCombo��5   w   $��35��6#    �� DisplayMemberPath$
 Name��6^   $��15(�6�     MaterialDesignComboBox#��[ 6�   $��246,61,31,0q�6G  $	��Top=�6\   �� SelectedValue 6/   �� *Office_ApplicationId+ 6�   �� *OfficeApplication+# [  $ TwoWay=�6\  �� 5      -   5        $ GebruikerTaalCombo��5   �   $��35��6#    �� SelectedValuePath$ 
LanguageId��6T   $ Translation��6s   $��15(�6�   #��[ 6�   $��10,132,284,0q�6k  $	��Top=�6�   6/   �� *
LanguageId+ 6�   �� *UserInterfaceLanguage+# [  $ TwoWay=�6�  �� 5      -   5        $��GUIDtxt��5   .   $��50��6"   $��15(�6=   #��[ 6K   $
 GUID��6�   $��10,177,284,85q�6�   �� 5      -   5        $��InstructieTaalCombo��5   �   $ 
LanguageId��6H   $ Translation��6g   $��35��6�   $��15(�6�   #��[ 6�   $��246,132,31,0q�6h  $	��Top=�6~   6#   �� *
LanguageId+ 6�   �� *InstructionLanguage+# [  $ TwoWay=�6~  �� 5       -   5         ��Name$ BtnFileUpload��5    !   $��30��68     MaterialDesignFlatButton#��[ 6D   
�������$��382,197,31,0q�6�   $	��Top=�6   ��6�   �� *uploadPhoto+# [  $ TwoWay=�6  �� 5!      -   5        $ txtFileName��5!   4    �� 
IsReadOnly$
 True��6"   $��246,177,114,85q�6I   $��15(�6a   #��[ 6o    6�   �� *uploadPhoto+# [  $ TwoWay=��� 5"      -	   5        $ btnSaveCourse��5"   !   #��[ 68   
�������$��284,261,129,19q�6�   ��6�   �� *Save+# [  $ TwoWay=�6�   �� 5#      -
   5        $��imagetxt��5#   n   $
��Left=�6"   $��565,165,0,0q�6=   $�� ��6R   $y�Hidden=�6Z    �� TextWrapping$
 Wrap=�6~   $	��Top=�6�   $	��120��6�   �� 5$      -   5        $ 	btnCancel��5$   !   #��[ 64   
�������$��382,261,31,19q�6�   ��6}   �� *Cancel+# [  $ TwoWay=�6�   �� 5%      -   5        $��
imageCombo��5%   X   $��41��6#   $
��Left=�6/   $��15(�6J   $��
10,252,0,0q�6�   #��[ 6�   $	��Top=�6R  $	��197��6j   6�   �� *ChoosePhoto+# [  $ TwoWay=�6j  �� 5&      -   5        $��image��5&   ;   $
��Left=�6    $��40��6H   $��212,252,0,0q�6T   $	��Top=�6i   $��44��6�   5'      � 5)      $��	491,0,0,0q�6   .+�5*      �� $ 	20 0 0 20��6!   ��5+      �� 5,   "    �� ImageSource$ ../Assets/e4p.jpg��6-    j� Stretch$
 Fill=�6M   5.      5/      50      51      52      53      54      