   M S B A M L   `   `   `  ���� B  >Appunti, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:APPUNTIAPPUNTI      APPUNTI.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     'localclr-namespace:APPUNTI     Q MElysium, Version=2.0.1042.4, Culture=neutral, PublicKeyToken=afa220db249e5b15/metro#http://schemas.codeplex.com/elysium  7params*http://schemas.codeplex.com/elysium/params    � 
ResizeMode$  CanMinimize=�   Elysium.Parameters.Manager   Theme Dark  Elysium.AccentBrushes   Green   AccentBrush# Z    BackgroundBrush#���    � Title$ Appunti��$	��500��$	��800��.��� .+��� -    ��Name$ pathnamebox��$�� ��$y�Hidden=��� -    ��Name$ 	TextPanel��$	��782��$��Center=�$	��Top=� �� AcceptsReturn$
 True�� �� TextWrapping$
 Wrap=�	 �� 
AcceptsTab$
	 True��$	��339��$	��Top=�� 
 � Orientation$
 Vertical=�$��Bottom=�$��Center=�.+��� $��5���� 
������ 
������� J� IsHitTestVisible$ False��.��� $
 
Horizontal=�.+��� $��
Caratteri:��
��������� -    ��Name$ charNum��$��0��
��������� $	�� | ��
��������� $��File:��
��������� -   $ PathName��$��Non salvato��
��������� $	�� | ��
��������� $��Salvataggio automatico:��
��������� -   $ AutoSaveStatusBool��$��No��
��������� $��5���� -    ��Name$ 
TopMostBtn��$+��%Mantieni in primo piano (disattivato)��$��Center=�$	��782���� $��5��� $
 
Horizontal=�$��Center=�$	��782��.+��� -   $ 	ExportBtn��$��Esporta file��$
��Left=�$	��326���� $��5���� -   $ GitBtn��$��GitHub��$��Right=�$	��120���� $��5���� -	   $ 	ImportBtn��$��Importa file��$��Right=�$	��326���� $��5��