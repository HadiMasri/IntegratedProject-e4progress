   M S B A M L   `   `   `  ����A  =UIUtil, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/$clr-namespace:UIUtil;assembly=UIUtilUIUtil  5   	   C.clr-namespace:UIUtil.Extension;assembly=UIUtilUIUtil.Extension  5   	   H DE4Progress.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:E4Progress.UI.StringsE4Progress.UI.Strings 5
      .   (E4Progress.UI.Views.UpdateQuestionDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :	converter$clr-namespace:UIUtil;assembly=UIUtil     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   8ext.clr-namespace:UIUtil.Extension;assembly=UIUtil  5   	   S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59Y	 UPrism.Unity.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/  	 5	      0resx#clr-namespace:E4Progress.UI.Strings  	 5
      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  True5        E4Progress.UI.Strings.SR   ResourceManager"   UIUtil.Extension.Translation   ResourceManager# Z 5       � Title$ UpdateQuestionDialog��5   	   $	��682��6&   $
��1105��63    � AllowsTransparency$
 True��6@    � WindowStartupLocation$ CenterScreen=�6Z   
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
21,35,21,0q�6   .+�5      ��  �� CornerRadius$ 2��6   $	��635��6&   ._�5      � 
�������.+�5      � $��	0,0,437,0q�6   .+�5      �� -   5         ��Name$ questionTypeCombo��5   #    �� SelectedValuePath$ QuestionTypeId��6g    �� DisplayMemberPath$ Translation��6�     MaterialDesignComboBox#��[ 6�   $
��Left=�6O  $��	40,26,0,0q�6j  $	��Top=�6}  $	��273��6�   �� SelectedValue 6>   �� *QuestionTypeId+)  #MaterialDesignThemes.Wpf.HintAssist   Hint 6�   �� *QuestionType+ �� 	Converter# [   �� Mode$ TwoWay=�6�  �� 5      -   5         ��Name$ masterQuestionCheckBox��5   �   $
��Left=�6�     MaterialDesignCheckBox#��[ 6�   $��	40,73,0,0q�6�   $	��Top=�6  $	��138��6  ��6#   �� *IsMasterQuestion+# [  $ TwoWay=�6  �� 5      -   5        $ masterQuestionCombo��5   #   $
��Left=�6@   $ Id��6x   $ Title��6�   #��[ 6�   $��
40,101,0,0q�6P  $	��Top=�6d  $	��273��6|   6[   �� *Id+ 6�   �� *MasterQuestion+# [  $ TwoWay=�6|  �� 5      -   5        $��instructionLanguageCombo��5   �   $
��Left=�6#   $ 
LanguageId��6c   $ Translation��6�   #��[ 6�   $��
40,139,0,0q�6n  $	��273��6�  $	��Top=�6�   6>   �� *
LanguageId+ 6�   �� *InstructionLanguage+# [  $ TwoWay=�6�  �� 5      -   5        $��userLanguageCombo��5   �   $
��Left=�6#   $ 
LanguageId��6c   $ Translation��6�   #��[ 6�   $��
346,26,0,0q�6i  $	��249��6}  $	��Top=�6�   6>   �� *
LanguageId+ 6�   �� *UserInterfaceLanguage+# [  $ TwoWay=�6�  �� 5      -   5        $" questionFormulationTypeCombo��5   #   $! Question_Formulation_TypeId��6   $ Translation��6�   $
��Left=�6�   #��[ 6�   $��
346,63,0,0q�6�  $	��Top=�6�  $	��249��6�   6I   �� *Question_Formulation_TypeId+ 6  �� *QuestionFormulationType+# [  $ TwoWay=�6�  �� 5       -   5        $ officeApplicationCombo��5    #   $ Office_ApplicationId��6C   $
 Name��6�   $
��Left=�6�   #��[ 6�   $��346,101,0,0q�6y  $	��Top=�6�  $	��249��6�   6l   �� *Office_ApplicationId+ 6�   �� *OfficeApplication+# [  $ TwoWay=�6�  �� 5!      -   5        $��titleTxt��5!   ~   $
��Left=�6N   $��346,139,0,0q�6i    % !MaterialDesignFloatingHintTextBox#��[ 6�    �� TextWrapping$
 Wrap=�67  $	��Top=�6K  $	��249��6c   6�   �� *Title+# [  $ TwoWay=�6c  �� 5"      -	   5         ��Name$ noteTxt��5"   >   $
��Left=�6"   #��[ 6O   $��
40,187,0,0q�6�   $
 Wrap=�6  $	��Top=�6   $	��273��68   6�   �� *Note+# [  $ TwoWay=�68  �� 5#      -
   5        $ versionNrTxt��5#   h   $
��Left=�6M   #��[ 6~   $��346,187,0,0q�6/  $
 Wrap=�6D  $	��Top=�6X  $	��249��6p   6�   �� *VersionNumber+# [  $ TwoWay=�6p  �� 5$      -   5        $ questionTxt��5$   =   $
��Left=�6"   #��[ 6R   $��
40,495,0,0q�6�   $
 Wrap=�6   �� AcceptsReturn$
 True��6&  $	��Top=�6;  $	��555��6S  $��81��6_   6�   �� *
Question+# [  $ TwoWay=�6_  �� 5%      -   5        
�������$
��Left=�5%   �     MaterialDesignFlatButton#��[ 6�   $��346,593,0,0q�6�   $	��Top=�6�   $	��100��6  ��68   �� *Cancel+# [  $ TwoWay=�6  �� 5&      -   5        
�������$
��Left=�5&   �   #��[ 6�   $��470,593,0,0q�6�   $	��Top=�6�   $	��110��6   ��68   �� *Save+# [  $ TwoWay=�6   �� 5'      -   5        $ 
comboThema��5'   �   $
��Left=�6#   $ Id��6[   $
 Name��6s   #��[ 6�   $��
40,245,0,0q�6?  $	��Top=�6S  $	��273��6k  $��41��6w   6>   �� *Id+ 6�   �� *Thema+# [  $ TwoWay=�6w  �� 5(      -   5        $ comboModelLevel��5(   �   $
��Left=�6#   $ Didactical_Model_LevelId��6>   $ Translation��6�   $��346,245,0,0q�6L  $	��Top=�6a  $	��249��6y  $��41��6�   6k   �� *Didactical_Model_LevelId+ 6�   �� *
ModelLevel+# [  $ TwoWay=�6�  �� 5)      -   5        $ isMesurableCheckBox��5)   �   #��[ 6�   $
��Left=�6�   $��42,0,0,0q�6�   $��Center=�6�   $	��205��6  ��6#   �� *IsMeasurable+# [  $ TwoWay=�6  �� 5*      -   5        $ txtLearningGoal��5*   =   $
��Left=�6"   #��[ 6�   $��
42,369,0,0q�6  $
 Wrap=�6  $	��Top=�60  $	��553��6H  $��47��6T   6W   �� *LearningGoal+# [  $ TwoWay=�6T  �� 5+      -   5        $ 	txtSkills��5+   =   $
��Left=�6"   $��
42,432,0,0q�6P   #��[ 6�   $
 Wrap=�6  $	��Top=�6"  $	��553��6:  $��46��6F   6d   �� *Skills+# [  $ TwoWay=�6F  5,      � 5-      $��	626,0,0,0q�6   .+�5.      �� $ 	20 0 0 20��6!   ��5/      �� 50   "    �� ImageSource$ ../Assets/e4p.jpg��6-    j� Stretch$
 Fill=�6M   52      53      55      56      57      58      59      