   M S B A M L   `   `   `  ����A  =UIUtil, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/$clr-namespace:UIUtil;assembly=UIUtilUIUtil  5   	   C.clr-namespace:UIUtil.Extension;assembly=UIUtilUIUtil.Extension  5   	   H DE4Progress.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:E4Progress.UI.StringsE4Progress.UI.Strings 5   	   *   $E4Progress.UI.Views.UpdateQuizDialog   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   4	converter$clr-namespace:UIUtil;assembly=UIUtil  5   	   8ext.clr-namespace:UIUtil.Extension;assembly=UIUtil  5   	   S OPrism.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59Y	 UPrism.Unity.Wpf, Version=8.0.0.1909, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59&prismhttp://prismlibrary.com/  	 5
   	   0resx#clr-namespace:E4Progress.UI.Strings  	 5   	   -   5          �Name$  Window��5   	   !  Prism.Mvvm.ViewModelLocator   AutoWireViewModel True5   	     E4Progress.UI.Strings.SR   ResourceManager"   UIUtil.Extension.Translation   ResourceManager# Z 5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�6.    � WindowStyle$
 None=�6D    � Title$ UpdateQuizDialog��5   	   $	��478��6"   $
��1002��6/   
������  � AllowsTransparency$
 True��6l   	 � 	Resources	 5         UIUtil.NewLineConverter   keyNewLineConverter��%   &	          5   
   6%   5      .��5      � $��5q�6   
 J� Effect
 5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6      	Direction$ 0Q�6.      RenderingBias$ Quality=�6<      ShadowDepth$ 1Q�6T      Color$
 Gray��6d   6s   .+�5   
   � 
������� � ColumnDefinitions 5      �� 5      �� 5      .+�5      � $��0��6   $��2��6#   $��	0,0,415,0q�67   .+�5      �� $��
15,15,0,15q�6   .+�5       ]� $	��570��6    $
��Left=�6,   $��0,0,0,10q�6G   .+�5!      �� -   5         ��Name$ 	TextTitle��5!   "   $��15(�65   $	��400��6C    % !MaterialDesignFloatingHintTextBox#��[ 6O   $
��Left=�6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint 6�   �� *Title+ �� 	Converter# [   �� Mode$ TwoWay=�6  �� 5"      -   5         ��Name$ TextNumberOfQuestions��5"   $    �� TextAlignment$ Right=�6C   $��Center=�6Y   $��20(�6t   $��Questions: 0��6�   $��0,0,15,0q�6�   6�   5#      ]� 5$      $	��570��6    $
��Left=�6,   $��0,0,0,10q�6G   .+�5%      �� -   5         ��Name$ PickerOffice��5%   #    �� DisplayMemberPath$
 Name��6h   $	��270��6�   $��15(�6�   $
��Left=�6�    �� SelectedValue 69   �� *Office_ApplicationId+6�   �� 5&      -   5        $ PickerInstructionLanguage��5&   #    �� SelectedValuePath$ 
LanguageId��6F   $ Translation��6e   $	��270��6�   $��15(�6�   $��Right=�6�   6�   5'      ]� 5(      $	��570��6    $
��Left=�6,   $��0,0,0,10q�6G   .+�5)      �� -   5        $ PickerUILanguage��5)   #   $ 
LanguageId��6=   $ Translation��6\   $	��270��6|   $��15(�6�   $
��Left=�6�   $��Bottom=�6�   6�   �� 5*      -   5        $ TextIdentificationCode��5*   "   $	��270��6B   $��15(�6N   #��[ 6\   $��Right=�6   6�   �� *IDCode+# [  $ TwoWay=�6$  5+      ]� 5,      $	��570��6    $
��Left=�6,   $��0,0,0,10q�6G   .+�5-      �� -   5        $ TextMinScore��5-   "   $	��270��68   $��15(�6D   #��[ 6R   $
��Left=�6�    6�   �� *
MinScore+# [  $ TwoWay=�6  ]� 5.      $	��270��6$   $��Right=�60   .+�5/      �� -	   5        $ 	TextHours��5/   &   $��80��69   $��15(�6D   $
��Left=�6R   #��[ 6m   $ HH��6�   $��0,0,10,0q�6�   6�   �� 50      -
   5        $ TextMinutes��50   &   $��80��6;   $��15(�6F   $
��Left=�6T   #��[ 6o   $ MM��6�   $��0,0,10,0q�6�   6�   �� 51      -   5        $ TextSeconds��51   &   $��80��6;   $��15(�6F   $
��Left=�6T   #��[ 6o   $ SS��6�   6�   52      53      ]� 54      $	��570��6    $
��Left=�6,   $��0,0,0,10q�6G   .+�55      �� -   5        $ TextShortIntro��55   "   $	��570��6:   $��15(�6F   $
��Left=�6T   #��[ 6o    6�   �� *
ShortIntro+# [  $ TwoWay=�6  56      ]� 57      $	��570��6    $
��Left=�6,   $��0,0,0,20q�6G   .+�58      �� -   5        $ 	TextIntro��58   "   $	��570��65   $��15(�6A   $
��Left=�6O   #��[ 6j    6�   �� *Intro+# [  $ TwoWay=�6  59      ]� 5:      $	��570��6    $
��Left=�6,   $��0,0,0,10q�6G   .+�5;      �� $��15(�6   $	��155��6�   $
��Left=�6�   ��6$   �� *CreationDate+# [  $ TwoWay=�6�   �� 5<      -   5        $ TextCreationDate��5<   $   $	��XXX��6>   $��15(�6I   6Y   5=      ]� 5>      $	��570��6    $
��Left=�6,   $��0,0,0,20q�6G   .+�5?      �� $��15(�6w   $	��155��6�   $
��Left=�6�   ��6$   �� *GUID+# [  $ TwoWay=�6�   �� 5@      -   5        $ TextReplicationKey��5@   $   $	��XXX��6@   $��15(�6K   6[   5A      ]� 5B      $��Right=�6    .+�5C      �� -   5         ��Name$ ButtonReturn��5C   !     MaterialDesignFlatButton#��[ 67   
�������$	��114��6�   $��0,0,10,0q�6�   ��6i   �� *Cancel+# [  $ TwoWay=�6  �� 5D      -   5        $ 
ButtonSave��5D   !   #��[ 65   
�������$	��120��6�   ��6g   �� *Save+# [  $ TwoWay=�6�   5E      5F      5G      � 5H      $��1��6   $��	101,0,0,0q�6#   .+�5I      ��  �� CornerRadius$ 	20 0 0 20��6   ��5J      �� 5K       �� ImageSource$ ../Assets/e4p.jpg��6%    j� Stretch$
 Fill=�6E   5M      5N      5O      5P      5Q      