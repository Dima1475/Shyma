   M S B A M L   `   `   `  ����Q  MShykment international, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:Shykment_internationalShykment_international  5      +    %Shykment_international.AllFilghtsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:Shykment_international     5        N� 
Background  �#5a6a8e N� Title$ AllFilghtsPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   .+�5   
   �� -   5        $��saveChanges��5      $+��%Сохрнаить изменения��6$   $��15(�6B   $��8q�6P   
������ $
��Left=�6u   $��0q�6�   
�������$��36��6�   $	��Top=�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��datagridAllFlights��5      $��1��6-      AutoGenerateColumns .     CanUserAddRows .     CanUserDeleteRows .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 
НОМЕР��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 64   �� *Number+6Q     5      	 6%   �� *Airlines.Name+ 5      �� 5      
 �� TextAlignment$
 Center=�6$   �� 6<   .�6@   
Авиа6F   �� 6K   6W   �� 6b   .�6f   компания6p   6v   5        5      $ ОТКУДА��6%   	 65   �� *Cities.Name+6W     5      $ 
ВЫЛЕТ��6%   	 64   �� *	Departure+6T     5      $ ПРИЛЕТ��6%   	 65   �� *	Arrival+6S     5      	 6%   �� *StartRegister+ 5      �� 5      $
 Center=�6$   �� 6<   .�6@   Начало6H   �� 6M   6Y   �� 6d   .�6h   регистрации6u   6{   5         5!      	 6%   �� *EndRegister+ 5"      �� 5#      $
 Center=�6$   �� 6<   .�6@   
Конец6G   �� 6L   6X   �� 6c   .�6g   регистрации6t   6z   5%        5&      $ Статус��6%      
IsReadOnly .  	 6H   �� *Status+6e   5(      5)      5*      