   M S B A M L   `   `   `  ���� D  @Dashboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Dashboard	Dashboard      Dashboard.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     -	dashboardclr-namespace:Dashboard       � Title$  Учет расходов��$	��500��$	��600�� � 	Resources ��  �� Type" ��   Keybrushes  .s���  �� Color$	 Red���� $
 Blue���� $ Green���� $ Yellow���� $ White���� $ Black���� $
 Gray��.��� .+���  �� Orientation$ Vertical=�.+��� .+��� -   $��42��$��30�� J� RenderTransformOrigin$ 0.046,0.417&�.���� $c��]C:\Users\kalin\OneDrive\Desktop\проект учёт\Dashboard\Dashboard\PieChart\person.png��$��42��$��30��$ 0.413,2.164&�   Dashboard.PieChartLayout  -     Name$ 
piePlotter��$��Center=�$��0��$��0��   PlottedProperty$
 Cash��$��10q�$	��195��$	��204��   ColorSelector %   Dashboard.IndexedColourSelector    brushes	   Brushes#	 [ �� $��
Траты��$
��Auto��$��10q�.���� $ 
Horizontal=�.+��� -   
 ��Name$
 ListBox1��$ �� IsSynchronizedWithCurrentItem$
 TrueY�$��10q�$	��150��$	��235������  �� View �� .P��� $��Категории�� �� Width$ 82�� �� DisplayMemberBinding �� *
Category+�� $��Наличка��$ 82�� �� *Cash+�� $��
Карта��$ 70�� �� *Card1+�� $��Детализация��$
��Auto��$��10q�.��� $��10q� � RowDefinitions �� $��30 ��� $��30 ��� $��30 ��� $��5 ��� $��30 ��� $��30 � � ColumnDefinitions �� $	��110 ��� $	��150 �.+��� $��25��$��0��$��0��$��0,0,0,7q�$"��Категория трат:���� $��23��$��1��$��0��$��0,0,20,0q����� *
Category+�� $��23��$��1��$��Наличные:���� $��23��$��1��$��1��$��0,0,20,0q����� *Cash+�� $��2��$��25��$��0,4,0,2q�$��2��$"��Карта основная:���� $��23��$��2��$��1��$��0,0,20,0q����� *Card1+�� -   $��2��$��0��$��23��$
��Auto��$
��Left=�$��3q�$��4��$8��2Добавить источник расходов��