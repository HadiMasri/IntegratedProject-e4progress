   M S B A M L   `   `   `  ����A  =UIUtil, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/$clr-namespace:UIUtil;assembly=UIUtilUIUtil  5   	   C.clr-namespace:UIUtil.Extension;assembly=UIUtilUIUtil.Extension  5   	   H DE4Progress.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:E4Progress.UI.StringsE4Progress.UI.Strings 5
   	   +   %E4Progress.UI.Views.NewQuestionDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :	converter$clr-namespace:UIUtil;assembly=UIUtil     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   8ext.clr-namespace:UIUtil.Extension;assembly=UIUtil  5   	   S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59Y	 UPrism.Unity.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/  	 5	   	   0resx#clr-namespace:E4Progress.UI.Strings  	 5
   	   !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5   	     E4Progress.UI.Strings.SR   ResourceManager"   UIUtil.Extension.Translation   ResourceManager# Z 5   	    � Title$ New Question��5   	   $	��682��6   $
��1105��6+    � AllowsTransparency$
 True��68    � WindowStartupLocation$ CenterScreen=�6R   
������  � 
ResizeMode$ NoResize=�6�    � WindowStyle$
 None=�6�    � 	Resources 5         UIUtil.NewLineConverter   keyNewLineConverter��%   &	          5   
   6%   5      .��5      � 	 J� Effect	 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5      
   
BlurRadius$
 5Q�6      	Direction$ 0Q�6.      RenderingBias$ Quality=�6<      ShadowDepth$ 1Q�6T      Color$
 Gray��6d   .+�5   
   �� $��
21,35,21,0q�6   .+�5      ��  �� CornerRadius$ 2��6   $	��636��6&   ._�5      � 
�������.+�5      � $��	0,0,437,0q�6   .+�5      �� -   5         ��Name$ questionTypeCombo��5   #    �� DisplayMemberPath$ Translation��6h     MaterialDesignComboBox#��[ 6�   $
��Left=�6-  $��	40,26,0,0q�6H  $	��Top=�6[  $	��273��6s   �� SelectedValue 6>   �� *QuestionTypeId+)  #MaterialDesignThemes.Wpf.HintAssist   Hint 6�   �� *QuestionType+ �� 	Converter# [   �� Mode$ TwoWay=�6s  �� 5      -   5         ��Name$ masterQuestionCheckBox��5   �   $
��Left=�6�     MaterialDesignCheckBox#��[ 6  $��	40,73,0,0q�6F  $	��Top=�6Y  $	��138��6q  ��6#   �� *IsMasterQuestion+# [  $ TwoWay=�6q  �� 5      -   5        $ masterQuestionCombo��5   #   $
��Left=�6@   $ Title��6z   #��[ 6�   $��
40,101,0,0q�6;  $	��Top=�6O  $	��273��6g   6\   �� *Id+ 6�   �� *MasterQuestion+# [  $ TwoWay=�6g  �� 5      -   5        $ instructionLanguageCombo��5   �   $
��Left=�6#    �� SelectedValuePath$ 
LanguageId��6c   $ Translation��6�   #��[ 6�   $��
40,160,0,0q�6q  $	��273��6�  $	��Top=�6�   6>   �� *
LanguageId+ 6�   �� *InstructionLanguage+# [  $ TwoWay=�6�  �� 5      -   5        $ userLanguageCombo��5   �   $
��Left=�6#   $ 
LanguageId��6c   $ Translation��6�   #��[ 6�   $��
346,26,0,0q�6k  $	��249��6  $	��Top=�6�   6>   �� *
LanguageId+ 6�   �� *UserInterfaceLanguage+# [  $ TwoWay=�6�  �� 5      -   5        $" questionFormulationTypeCombo��5   #   $ Translation��6s   $
��Left=�6�   #��[ 6�   $��
346,68,0,0q�6^  $	��Top=�6r  $	��249��6�   6I   �� *QuestionTypeId+ 6�   �� *QuestionFormulationType+# [  $ TwoWay=�6�  �� 5       -   5        $ officeApplicationCombo��5    #   $
 Name��6s   $
��Left=�6�   #��[ 6�   $��346,101,0,0q�6Q  $	��Top=�6f  $	��249��6~   6D   �� *Office_ApplicationId+ 6�   �� *OfficeApplication+# [  $ TwoWay=�6~  �� 5!      -   5         ��Name$ titleTxt��5!   ~   $
��Left=�6N   $��346,145,0,0q�6i    % !MaterialDesignFloatingHintTextBox#��[ 6�    �� TextWrapping$
 Wrap=�69  $	��Top=�6M  $	��249��6e   6�   �� *Title+# [  $ TwoWay=�6e  �� 5"      -	   5        $ noteTxt��5"   ?   $
��Left=�6#   #��[ 6P   $��
40,201,0,0q�6�   $
 Wrap=�6  $	��Top=�6!  $	��273��69   6�   �� *Note+# [  $ TwoWay=�69  �� 5#      -
   5        $ versionNrTxt��5#   h   $
��Left=�6M   #��[ 6~   $��346,201,0,0q�6/  $
 Wrap=�6D  $	��Top=�6X  $	��249��6p   6�   �� *VersionNumber+# [  $ TwoWay=�6p  �� 5$      -   5        $ 
comboThema��5$   �   $
��Left=�6#   $ Id��6[   $
 Name��6s   $��
40,257,0,0q�6�   $	��Top=�6�   #��[ 6�   $	��273��6k   6>   �� *Id+ 6�   �� *Thema+# [  $ TwoWay=�6k  �� 5%      -   5        $ questionTxt��5%   ?   $��Center=�6"   #��[ 6T   $��	0,493,0,0q�6   $
 Wrap=�6   �� AcceptsReturn$
 True��6'  $	��Top=�6<  $	��555��6T  $��81��6`   6�   �� *
Question+# [  $ TwoWay=�6`  �� 5&      -   5        $ comboModelLevel��5&   �   $
��Left=�6#   $ Translation��6r   $��346,257,0,0q�6  $	��Top=�64  $	��249��6L   6>   �� *Didactical_Model_LevelId+ 6�   �� *
ModelLevel+# [  $ TwoWay=�6L  �� 5'      -   5        $ txtLearningGoal��5'   =   $
��Left=�6"   #��[ 6�   $��
42,349,0,0q�6  $
 Wrap=�6  $	��Top=�60  $	��553��6H  $��57��6T   6W   �� *LearningGoal+# [  $ TwoWay=�6T  �� 5(      -   5        $ 	txtSkills��5(   =   $
��Left=�6"   $��
40,425,0,0q�6P   #��[ 6�   $
 Wrap=�6  $	��Top=�6"  $	��555��6:  $��50��6F   6d   �� *Skills+# [  $ TwoWay=�6F  �� 5)      -   5        
�������$
��Left=�5)   �     MaterialDesignFlatButton#��[ 6�   $��346,594,0,0q�6�   $	��Top=�6�   $	��100��6  ��68   �� *Cancel+# [  $ TwoWay=�6  �� 5*      -   5        
�������$
��Left=�5*   �   #��[ 6�   $��485,594,0,0q�6�   $	��Top=�6�   $	��110��6  ��68   �� *Save+# [  $ TwoWay=�6  �� 5+      -   5        $ isMesurableCheckBox��5+   �   #��[ 6�   $
��Left=�6�   $��42,0,0,0q�6�   $��Center=�6�   $	��205��6  ��6#   �� *IsMeasurable+# [  $ TwoWay=�6  5,      � 5.      $��	626,0,0,0q�6   .+�5/      �� $ 	20 0 0 20��6!   ��50      �� 51   "    �� ImageSource$ ../Assets/e4p.jpg��6-    j� Stretch$
 Fill=�6M   53      54      57      58      59      5:      5;      