   M S B A M L   `   `   `  ����H  DWPF - Projekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WPF___ProjektWPF___Projekt  5   	       WPF___Projekt.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:WPF___Projekt     5   	   -   5          � Title$  
MainWindow��5   	   $	��650��6   $
��1550��6)   .��5
      ]� .+�5   
   �� $	��Top=�6    �� Padding$
 10 5q�5      
��� d �
�������$
��Wrap=�6M   ��5   )   ��  �� ElementName$ 
tabControl�� �� Path$ SelectedItem.Tag�5   M   �� 5   
   -   5        $��
tabControl��5   ;   $��4q�6    �� TabStripPlacement$ Bottom=�6    .@�5      �� $��Zamówienia��6   
 � Tag$- 'Tutaj możesz dodawać nowe zamówienia��6*   .��5      � .+�5      � $
��Left=�6   $	��377��66   $��10,0,0,0q�6C   $��Center=�6U   $	��130��6p   .+�5      �� -   5        $��AddOrderButton��5   !   $��Dodaj��67   $��18(�6G   $
��Bold"�6U   $��Center=�6g   $��0,20,0,0q�6�   $	��Top=�6�   $��40��6�   $	��110��6�   6�   �� 5      -   5        $��EditOrderButton��5   !   $��Edytuj��68   $��18(�6I   $
��Bold"�6W   $��Center=�6i   $��0,80,0,0q�6�   $	��Top=�6�   $��40��6�   $	��110��6�   6�   �� 5      -   5        $��DeleteOrderButton��5   !   $��Usuń��6:   $��18(�6I   $
��Bold"�6W   $��Center=�6i   $��	0,140,0,0q�6�   $	��Top=�6�   $��40��6�   $	��110��6�   6�   �� 5      -   5        $��ViewOrderButton��5   !   $��	Podejrzyj��68   $��18(�6L   $
��Bold"�6Z   $��Center=�6l   $��	0,200,0,0q�6�   $	��Top=�6�   $��40��6�   $	��110��6�   6�   �� 5      -   5        $��PrintOrderButton��5   !   $��Drukuj��69   $��18(�6J   $
��Bold"�6X   $��Center=�6j   $��	0,260,0,0q�6�   $	��Top=�6�   $��40��6�   $	��110��6�   6�   �� 5      -   5        $��MapOrderButton��5   !   $
��Mapa��67   $��18(�6F   $
��Bold"�6T   $��Center=�6f   $��	0,320,0,0q�6�   $	��Top=�6�   $��40��6�   $	��110��6�   6�   5      � 5      $
��Left=�6   $	��487��66   $��	161,0,0,0q�6C   $��Center=�6V   $	��319��6q   .+�5      �� -	   5        $��listOfOrders��5   "    �� SelectionMode$ Single=�66   $��	0,10,0,10q�6f    �� DisplayMemberPath$ NameAndPrice��6y   5      � 5"      $
��Left=�6_   $	��487��6z   $��	526,0,0,0q�6�   $��Center=�6�   $	��586��6�    � DataContext 6   �� $ listOfOrders��$ SelectedItem�	 � RowDefinitions	 5#      �� 5$      $
��Auto �6,   �� 5%      $
��Auto �6,   �� 5&      $
��Auto �6,   �� 5'      $
��Auto �6,   �� 5(      $��* �6,   �� 5)      $
��Auto �6,   .+�5,      � $��0��6   	 5-      �� 5.   "   �� 5/   "   �� 50   "   �� 51   "   �� 52   "   �� 53   "   �� 54   "   �� 55   "   
 � ColumnDefinitions
 57      �� 58   "   $
��Auto �63   �� 59   "   �� 5:   "   $
��Auto �63   .+�5>      �� -
   5        $��Order_NameSurname��5>   $   $��0��6=   $��0��6M   $��Nazwa przesyłki��6Z   $��Center=�6t   $��3q�6�   �� 5?      -   5        $��Order_txtNameSurname��5?   &   $��1��6d   $��0��6t   $��Center=�6�   $��3q�6�   ��6B   �� $ NameSurname�6�   �� 5@      -   5        $��Order_btnNameSurname��5@   %   $��2��6A   $��0��6Q   $	��...��6^   $��Center=�6l   $
��10,3q�6�   $��3q�6�   �� 5B      -   5        $��Order_CourierID��5B   $   $��0��6;   $��1��6K   $��Kurier��6X   $��Center=�6i   $��3q�6�   �� 5C      -   5        $��Order_txtCourierID��5C   '   $��1��6a   $��1��6q   $��Center=�6~   $��3q�6�    �� Text 6A   �� $ 	CourierID�6�   �� 5D      -   5        $��Order_btnCourierID��5D   %   $��2��6?   $��1��6O   $	��...��6\   $��Center=�6j   $
��10,3q�6�   $��3q�6�   �� 5F      -   5        $��Order_ClientID��5F   $   $��0��6:   $��2��6J   $��Klient��6W   $��Center=�6h   $��3q�6�   �� 5G      -   5        $��Order_txtClientID��5G   '   $��1��6_   $��2��6o   $��Center=�6|   $��3q�6�    6@   �� $ ClientID�6�   �� 5H      -   5        $��Order_btnClientID��5H   %   $��2��6>   $��2��6N   $	��...��6[   $��Center=�6i   $
��10,3q�6�   $��3q�6�   �� 5J      -   5        $��Order_Payment��5J   $   $��Wpłata��69   $��0��6J   $��3��6Z   $��Center=�6h   $��3q�6�   �� 5K      -   5        $��Order_scrollbarPayment��5K   (   $��1��6e   $��3��6u    �� Orientation$ 
Horizontal=�6�    � Value 6F   �� $ Payment�6�   �� 5L      -   5        $��Order_txtPayment��5L   &   $��2��6>   $��3��6N   $��Center=�6\   $
��10,3q�6w   $��3q�6�   �� 5N      -   5        $��Order_ArriveWhen��5N   $   $��
Realizacja��6<   $��0��6R   $��4��6b   $��Center=�6o   $��3,0,3,0q�6�   �� 5O      -   5        $��Order_cmbArriveWhen��5O   '   $��1��6o   $��4��6   $��Center=�5P   '   $��2��6B   $��2,7,4,6.667q�6V    �� SelectedIndex 5O   B   �� $ PackageStatus�.@�5Q   "   �� -   5        $
��arr1��5Q   /   $��Nie śpiesz się��6;   $��3q�6T   �� 5R   "   -   5        $
��arr2��5R   /   $��Standard��6;   $��3q�6N   �� 5S   "   -   5        $
��arr3��5S   /   $��Ekspres��6;   $��3q�6M   5T      �� 5V      -   5        $��Order_PackageStatus��5V   $   $��Status paczki��6?   $��0��6X   $��5��6h   $��Center=�6u   $��3,0,3,0q�6�   �� 5W      -   5        $��Order_cmbPackageStatus��5W   '   $��1��6r   $��5��6�   $��Center=�5X   '   $��2��6B   $��2,7,4,6.667q�6V   
����  � 5W   E   �� $ PackageStatus�.@�5Y   "   �� -   5        $��status1��5Y   /   $��Oczekująca��6>   $��3q�6S   �� 5Z   "   -   5        $��status2��5Z   /   $��	Opłacona��6>   $��3q�6Q   �� 5[   "   -   5        $��status3��5[   /   $��W drodze��6>   $��3q�6Q   �� 5\   "   -    5        $��status4��5\   /   $��Dostarczona��6>   $��3q�6T   5]      �� 5_      -!   5        $��Order_Format��5_   '   $��Adres��6;   $��0��6J   $��6��6Z   $��2��6g   $��3q�6{   .��5`   "   � $��Center=�6'   	 5a   &   �� 5b   *   $
��Auto �68   �� 5c   *   $
��Auto �68   �� 5d   *   $
��Auto �68   
 5f   &   �� 5g   *   $��60 �6;   �� 5h   *   $��60 �6;   �� 5i   *   $��40 �6;   �� 5j   *   $��60 �6;   �� 5k   *   $��50 �6;   �� 5l   *   $��60 �6;   �� 5m   *   .+�5o   &   �� -"   5        $��Order_Street��5o   ,   $��Miasto��6@   $��0��6Q   $��3,0,3,0q�6a   $��Center=�6r   $��2��6�   $��26��6�   �� 5p   &   -#   5        $��
Order_City��5p   ,   $��Ulica��6>   $��1��6N   $��0��6[   $��3,0,3,0q�6k   $��Center=�6|   $��2��6�   $��26��6�   �� 5q   &   -$   5        $��
Order_Code��5q   ,   $	��Kod��6>   $��2��6L   $��2��6\   $��3,0,4,0q�6i   $��Center=�6z   $��26��6�   �� 5r   &   -%   5        $��Order_Phone��5r   ,   $��Telefon��6?   $��4��6Q   $��2��6a   $��3,0,3,0q�6n   $��Center=�6   $��2��6�   $��26��6�   �� 5t   &   -&   5        $��Order_txtCity��5t   .   $��2��6^   $��3,0,4,0q�6n   $��Center=�6   $��18��6�   $��10��6�   ��6C   �� $
 City�6�   �� 5u   &   -'   5        $��Order_txtStreet��5u   .   $��2��6b   $��1��6r   $��3,0,4,0q�6   $��Center=�6�   $��18��6�   $��10��6�   ��6E   �� $ Street�6�   �� 5v   &   -(   5        $��Order_txtCode��5v   .   $��3��6^   $��2��6n   $��0,0,4,0q�6{   $��Center=�6�   $��18��6�   $��1��6�   ��6C   �� $
 Code�6�   �� 5w   &   -)   5        $��Order_txtPhone��5w   .   $��5��6a   $��2��6q   $��0,0,4,0q�6~   $��Center=�6�   $��18��6�   $��2��6�   ��6E   �� $ Phone�6�   5x   #   5y      5z      � 5�      $��3��6   
 5�      �� 5�   "   $��* �63   �� 5�   "   $��* �63   �� 5�   "   $��* �63   .+�5�      �� $��Dodatkowe uwagi:��6$   $��0��6?   $��2��6O   $��Center=�6\   $��28��6x   $��3,0,3,0q�6�   �� 5�      -*   5        $��btnOrderSummary��5�   %   $��Sprawdź��6=   $��2��6O   $��2��6_   $��Center=�6l    �� 	IsDefault . $��3,0,3,0q�6�   6�   5�      �� 5�      -+   5        $��txtOrderSummary��5�   "   $��0��6[   $��4��6k    �� TextWrapping$
 Wrap=�6x    �� AcceptsReturn . " �� VerticalScrollBarVisibility$ Visible=�6�   $��10,5,3,3q�6�   ��69   �� $ Description�6�   �� 5�      $��5��6%    �� Orientation$ 
Horizontal=�62   $��Center=�6K   $��Right=�6f   .+�5�      �� -,   5        $��
btnOrderOk��5�   %   $��Dodaj nową osobę��67   $
��20,3q�6R   $��3q�6a    . 6}   �� 5�      --   5        $��btnOrderCancel��5�   %   $��Anuluj��6;   $
��20,3q�6L   $��3q�6[    �� IsCancel . 6v   5�      5�      5�      5�      �� 5�      $��Kurierzy��6   $- 'Tutaj możesz dodawać nowych kurierów��6(   .��5�      � .+�5�      � $
��Left=�6   $	��377��66   $��10,0,0,0q�6C   $��Center=�6U   $	��130��6p   .+�5�      �� -.   5        $��AddCourierButton��5�   !   $��Dodaj��69   $��18(�6I   $
��Bold"�6W   $��Center=�6i   $��0,20,0,0q�6�   $	��Top=�6�   $��40��6�   $	��110��6�   6�   �� 5�      -/   5        $��EditCourierButton��5�   !   $��Edytuj��6:   $��18(�6K   $
��Bold"�6Y   $��Center=�6k   $��0,80,0,0q�6�   $	��Top=�6�   $��40��6�   $	��110��6�   6�   �� 5�      -0   5        $��DeleteCourierButton��5�   !   $��Usuń��6<   $��18(�6K   $
��Bold"�6Y   $��Center=�6k   $��	0,140,0,0q�6�   $	��Top=�6�   $��40��6�   $	��110��6�   6�   �� 5�      -1   5        $��ViewCourierButton��5�   !   $��	Podejrzyj��6:   $��18(�6N   $
��Bold"�6\   $��Center=�6n   $��	0,200,0,0q�6�   $	��Top=�6�   $��40��6�   $	��110��6�   6�   �� 5�      -2   5        $��PrintCourierButton��5�   !   $��Drukuj��6;   $��18(�6L   $
��Bold"�6Z   $��Center=�6l   $��	0,260,0,0q�6�   $	��Top=�6�   $��40��6�   $	��110��6�   6�   �� 5�      -3   5        $��MapCourierButton��5�   !   $
��Mapa��69   $��18(�6H   $
��Bold"�6V   $��Center=�6h   $��	0,320,0,0q�6�   $	��Top=�6�   $��40��6�   $	��110��6�   6�   5�      � 5�      $
��Left=�6   $	��487��66   $��	161,0,0,0q�6C   $��Center=�6V   $	��319��6q   .+�5�      �� -4   5        $��listOfCouriers��5�   "   $ Single=�68   $��	0,10,0,10q�6j   $ NameAndPrice��6}   5�      � 5�      $
��Left=�6a   $	��487��6|   $��	526,0,0,0q�6�   $��Center=�6�   $	��586��6�    6   �� $ listOfCouriers��$ SelectedItem�	 5�      �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   �� 5�      $��* �6,   �� 5�      $
��Auto �6,   .+�5�      � $��0��6   	 5�      �� 5�   "   �� 5�   "   �� 5�   "   �� 5�   "   �� 5�   "   �� 5�   "   
 5�      �� 5�   "   $
��Auto �63   �� 5�   "   �� 5�   "   $
��Auto �63   .+�5�      �� -5   5        $��Courier_NameSurname��5�   $   $��0��6?   $��0��6O   $��Imię i Nazwisko��6\   $��Center=�6v   $��3q�6�   �� 5�      -6   5        $��Courier_txtNameSurname��5�   &   $��1��6f   $��0��6v   $��Center=�6�   $��3q�6�   ��6D   �� $ NameSurname�6�   �� 5�      -7   5        $��Courier_btnNameSurname��5�   %   $��2��6C   $��0��6S   $	��...��6`   $��Center=�6n   $
��10,3q�6�   $��3q�6�   �� 5�      -8   5        $��Courier_Email��5�   $   $��0��69   $��1��6I   $��Email��6V   $��Center=�6f   $��3q�6�   �� 5�      -9   5        $��Courier_txtEmail��5�   &   $��1��6Z   $��1��6j   $��Center=�6w   $��3q�6�   ��6>   �� $ Email�6�   �� 5�      -:   5        $��Courier_btnEmail��5�   %   $��2��6=   $��1��6M   $	��...��6Z   $��Center=�6h   $
��10,3q�6�   $��3q�6�   �� 5�      -;   5        $��Courier_Phone��5�   $   $��0��69   $��2��6I   $��Telefon��6V   $��Center=�6h   $��3q�6�   �� 5�      -<   5        $��Courier_txtPhone��5�   &   $��1��6Z   $��2��6j   $��Center=�6w   $��3q�6�   ��6>   �� $ Phone�6�   �� 5�      -=   5        $��Courier_btnPhone��5�   %   $��2��6=   $��2��6M   $	��...��6Z   $��Center=�6h   $
��10,3q�6�   $��3q�6�   5�      � 5�      $��3��6   
 5�      �� 5�   "   $��* �63   �� 5�   "   $��* �63   �� 5�   "   $��* �63   .+�5�      �� $��Dodatkowe informacje:��6$   $��0��6D   $��2��6T   $��Center=�6a   $��28��6}   $��3,0,3,0q�6�   �� 5�      ->   5        $��btnCourierSummary��5�   %   $��Sprawdź��6?   $��2��6Q   $��2��6a   $��Center=�6n    . $��3,0,3,0q�6�   6�   5�      �� 5�      -?   5        $��txtCourierSummary��5�   "   $��0��6]   $��4��6m   $
 Wrap=�6z    . $ Visible=�6�   $��10,5,3,3q�6�   ��6;   �� $ Description�6�   �� 5�      $��5��6%   $ 
Horizontal=�62   $��Center=�6K   $��Right=�6f   .+�5�      �� -@   5        $��btnCourierOk��5�   %   $��Dodaj nową osobę��69   $
��20,3q�6T   $��3q�6c    . 6   �� 5�      -A   5        $��btnCourierCancel��5�   %   $��Anuluj��6=   $
��20,3q�6N   $��3q�6]    . 6x   5�      5�      5�      5�      �� 5�      $��Klienci��6   $- 'Tutaj możesz dodawać nowych klientów��6'   $
��-2,0q�6R   .��5�      � .+�5�      � $
��Left=�6   $	��377��66   $��10,0,0,0q�6C   $��Center=�6U   $	��130��6p   .+�5�      �� -B   5        $��AddClientButton��5�   !   $��Dodaj��68   $��18(�6H   $
��Bold"�6V   $��Center=�6h   $��0,20,0,0q�6�   $	��Top=�6�   $��40��6�   $	��110��6�   6�   �� 5�      -C   5        $��EditClientButton��5�   !   $��Edytuj��69   $��18(�6J   $
��Bold"�6X   $��Center=�6j   $��0,80,0,0q�6�   $	��Top=�6�   $��40��6�   $	��110��6�   6�   �� 5�      -D   5        $��DeleteClientButton��5�   !   $��Usuń��6;   $��18(�6J   $
��Bold"�6X   $��Center=�6j   $��	0,140,0,0q�6�   $	��Top=�6�   $��40��6�   $	��110��6�   6�   �� 5�      -E   5        $��ViewClientButton��5�   !   $��	Podejrzyj��69   $��18(�6M   $
��Bold"�6[   $��Center=�6m   $��	0,200,0,0q�6�   $	��Top=�6�   $��40��6�   $	��110��6�   6�   �� 5�      -F   5        $��PrintClientButton��5�   !   $��Drukuj��6:   $��18(�6K   $
��Bold"�6Y   $��Center=�6k   $��	0,260,0,0q�6�   $	��Top=�6�   $��40��6�   $	��110��6�   6�   �� 5�      -G   5        $��MapClientButton��5�   !   $
��Mapa��68   $��18(�6G   $
��Bold"�6U   $��Center=�6g   $��	0,320,0,0q�6�   $	��Top=�6�   $��40��6�   $	��110��6�   6�   5�      � 5�      $
��Left=�6   $	��487��66   $��	161,0,0,0q�6C   $��Center=�6V   $	��319��6q   .+�5�      �� -H   5        $��listOfClients��5�   "   $ Single=�67   $��	0,10,0,10q�6h   $ NameAndPrice��6{   5�      � 5�      $
��Left=�6`   $	��487��6{   $��	526,0,0,0q�6�   $��Center=�6�   $	��586��6�    6   �� $ listOfClients��$ SelectedItem�	 5�      �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   �� 5�      $
��Auto �6,   �� 5      $��* �6,   �� 5     $
��Auto �6,   .+�5     � $��0��6   	 5     �� 5  "   �� 5  "   �� 5  "   �� 5	  "   �� 5
  "   �� 5  "   �� 5  "   �� 5  "   
 5     �� 5  "   $
��Auto �63   �� 5  "   �� 5  "   $
��Auto �63   .+�5     �� -I   5        $��Client_NameSurname��5  $   $��0��6>   $��0��6N   $��Imię i Nazwisko��6[   $��Center=�6u   $��3q�6�   �� 5     -J   5        $��Client_txtNameSurname��5  &   $��1��6e   $��0��6u   $��Center=�6�   $��3q�6�   ��6C   �� $ NameSurname�6�   �� 5     -K   5        $��Client_btnNameSurname��5  %   $��2��6B   $��0��6R   $	��...��6_   $��Center=�6m   $
��10,3q�6�   $��3q�6�   �� 5     -L   5        $��Client_Gender��5  $   $��Płeć��69   $��0��6I   $��2��6Y   $��Center=�6f   $��3,0,3,0q�6�   �� 5     -M   5        $��Client_cmbGender��5  '   $��1��6e   $��2��6u   $��Center=�6�   $��2��6�   $��2,7,4,6.667q�6�    6?   �� $ Gender�.@�5  "   �� -N   5        $��Client_male��5  /   $��Mężczyzna��6B   $��3q�6V   �� 5  "   -O   5        $��Client_female��5  /   $��Kobieta��6D   $��3q�6V   �� 5  "   -P   5        $��Client_unknown��5  /   $��Nieznane��6E   $��3q�6X   5     �� 5      -Q   5        $��Client_Date��5   $   $��Data urodzenia��67   $��0��6P   $��3��6`   $��Center=�6n   $��3q�6�   (  "System.Windows.Controls.DatePicker  5!     -R   5        $��Client_datepick��5!  )   $��1��5"  )   $��3��69   $��5,5,5,5q�6F   $��2��6W      SelectedDate 5!  h   �� $ DATEDateOfBirth�5"  W   �� 5%     -S   5        $��Client_Province��5%  $   $��Województwo��6;   $��0��6R   $��4��6b   $��Center=�6o   $��3,0,3,0q�6�   �� 5&     -T   5        $��Client_cmbProvince��5&  '   $��1��6i   $��4��6y   $��Center=�6�   $��2��6�   $��2,7,4,6.667q�6�    6A   �� $ Province�.@�5'  "   �� -U   5        $��
cmbClient1��5'  /   $��	Podlaskie��6A   �� 5(  "   -V   5        $��
cmbClient2��5(  /   $��Dolnośląskie��6A   �� 5)  "   -W   5        $��
cmbClient3��5)  /   $��Kujawsko-pomorskie��6A   �� 5*  "   -X   5        $��
cmbClient4��5*  /   $��	Lubelskie��6A   �� 5+  "   -Y   5        $��
cmbClient5��5+  /   $��Lubuskie��6A   �� 5,  "   -Z   5        $��
cmbClient6��5,  /   $��	Łódzkie��6A   �� 5-  "   -[   5        $��
cmbClient7��5-  /   $��Mazowieckie��6A   �� 5.  "   -\   5        $��
cmbClient8��5.  /   $��Małopolskie��6A   �� 5/  "   -]   5        $��
cmbClient9��5/  /   $��Opolskie��6A   �� 50  "   -^   5        $��cmbClient10��50  /   $��Podkarpackie��6B   �� 51  "   -_   5        $��cmbClient11��51  /   $��	Pomorskie��6B   �� 52  "   -`   5        $��cmbClient12��52  /   $��	Śląskie��6B   �� 53  "   -a   5        $��cmbClient13��53  /   $��Świętokrzyskie��6B   �� 54  "   -b   5        $��cmbClient14��54  /   $��Warmińsko-mazurskie��6B   �� 55  "   -c   5        $��cmbClient15��55  /   $��Wielkopolskie��6B   �� 56  "   -d   5        $��cmbClient16��56  /   $��Zachodnio-pomorskie��6B   57     �� 59     -e   5        $��Client_Email��59  $   $��0��68   $��5��6H   $��Email��6U   $��Center=�6e   $��3q�6�   �� 5:     -f   5        $��Client_txtEmail��5:  &   $��1��6Y   $��5��6i   $��Center=�6v   $��3q�6�   ��6=   �� $ Email�6�   �� 5;     -g   5        $��Client_btnEmail��5;  %   $��2��6<   $��5��6L   $	��...��6Y   $��Center=�6g   $
��10,3q�6�   $��3q�6�   �� 5>     -h   5        $��Client_Format��5>  '   $��Adres��6<   $��0��6K   $��6��6[   $��3��6h   $��3q�6|   .��5?  "   � $��Center=�6'   	 5@  &   �� 5A  *   $
��Auto �68   �� 5B  *   $
��Auto �68   �� 5C  *   $
��Auto �68   
 5E  &   �� 5F  *   $��60 �6;   �� 5G  *   $��60 �6;   �� 5H  *   $��40 �6;   �� 5I  *   $��60 �6;   �� 5J  *   $��50 �6;   �� 5K  *   $��60 �6;   �� 5L  *   .+�5N  &   �� -i   5        $��Client_Street��5N  ,   $��Miasto��6A   $��0��6R   $��3,0,3,0q�6b   $��Center=�6s   $��2��6�   $��26��6�   �� 5O  &   -j   5        $��Client_City��5O  ,   $��Ulica��6?   $��1��6O   $��0��6\   $��3,0,3,0q�6l   $��Center=�6}   $��2��6�   $��26��6�   �� 5P  &   -k   5        $��Client_Code��5P  ,   $	��Kod��6?   $��2��6M   $��2��6]   $��3,0,4,0q�6j   $��Center=�6{   $��26��6�   �� 5Q  &   -l   5        $��Client_Phone��5Q  ,   $��Telefon��6@   $��4��6R   $��2��6b   $��3,0,3,0q�6o   $��Center=�6�   $��2��6�   $��26��6�   �� 5S  &   -m   5        $��Client_txtCity��5S  .   $��2��6_   $��3,0,4,0q�6o   $��Center=�6�   $��18��6�   $��10��6�   ��6D   �� $
 City�6�   �� 5T  &   -n   5        $��Client_txtStreet��5T  .   $��2��6c   $��1��6s   $��3,0,4,0q�6�   $��Center=�6�   $��18��6�   $��10��6�   ��6F   �� $ Street�6�   �� 5U  &   -o   5        $��Client_txtCode��5U  .   $��3��6_   $��2��6o   $��0,0,4,0q�6|   $��Center=�6�   $��18��6�   $��1��6�   ��6D   �� $
 Code�6�   �� 5V  &   -p   5        $��Client_txtPhone��5V  .   $��5��6b   $��2��6r   $��0,0,4,0q�6   $��Center=�6�   $��18��6�   $��2��6�   ��6F   �� $ Phone�6�   5W  #   5X     5Y     � 5\     $��2��6   
 5]     �� 5^  "   $��* �63   �� 5_  "   $��* �63   �� 5`  "   $��* �63   5b     � 5e     $��3��6   
 5f     �� 5g  "   $��* �63   �� 5h  "   $��* �63   �� 5i  "   $��* �63   .+�5k     �� $��Dodatkowe informacje:��6$   $��0��6D   $��2��6T   $��Center=�6a   $��28��6}   $��3,0,3,0q�6�   �� 5l     -q   5        $��btnClientSummary��5l  %   $��Sprawdź��6>   $��2��6P   $��2��6`   $��Center=�6m    . $��3,0,3,0q�6�   6�   5m     �� 5p     -r   5        $��txtClientSummary��5p  "   $��0��6\   $��4��6l   $
 Wrap=�6y    . $ Visible=�6�   $��10,5,3,3q�6�   ��6:   �� $ Description�6�   �� 5r     $��5��6%   $ 
Horizontal=�62   $��Center=�6K   $��Right=�6f   .+�5s     �� -s   5        $��btnClientOk��5s  %   $��Dodaj nową osobę��68   $
��20,3q�6S   $��3q�6b    . 6~   �� 5t     -t   5        $��btnClientCancel��5t  %   $��Anuluj��6<   $
��20,3q�6M   $��3q�6\    . 6w   5u     5v     5w     5x     �� 5|     $��Template��6   $" Podstawowa funkcjonalność.��6(   .��5}     � .+�5~     � $
��Left=�6   $	��254��66   $��10,0,0,0q�6C   $��Center=�6U   $	��130��6p   .+�5     �� -u   5        $��	AddButton��5  !   $��Dodaj��62   $��18(�6B   $
��Bold"�6P   $��Center=�6b   $��0,20,0,0q�6   $	��Top=�6�   $��40��6�   $	��110��6�   6�   �� 5�     -v   5        $��
EditButton��5�  !   $��Edytuj��63   $��18(�6D   $
��Bold"�6R   $��Center=�6d   $��0,80,0,0q�6�   $	��Top=�6�   $��40��6�   $	��110��6�   6�   �� 5�     -w   5        $��DeleteButton��5�  !   $��Usuń��65   $��18(�6D   $
��Bold"�6R   $��Center=�6d   $��	0,140,0,0q�6�   $	��Top=�6�   $��40��6�   $	��110��6�   6�   �� 5�     -x   5        $��
ViewButton��5�  !   $��	Podejrzyj��63   $��18(�6G   $
��Bold"�6U   $��Center=�6g   $��	0,200,0,0q�6�   $	��Top=�6�   $��40��6�   $	��110��6�   6�   5�     � 5�     $
��Left=�6   $	��487��66   $��	161,0,0,0q�6C   $��Center=�6V   $	��319��6q   .+�5�     �� -y   5        $��listOfItems��5�  9   $ Single=�6"   $��	0,10,0,10q�6f   $ NameAndPrice��6y   5�     � 5�     $
��Left=�6^   $	��487��6y   $��	526,0,0,0q�6�   $��Center=�6�   $	��586��6�    6   �� $ listOfItems��$ SelectedItem�	 5�     �� 5�     $
��Auto �6,   �� 5�     $
��Auto �6,   �� 5�     $
��Auto �6,   �� 5�     $
��Auto �6,   �� 5�     $��* �6,   �� 5�     $
��Auto �6,   .+�5�     � $��0��6   	 5�     �� 5�  "   �� 5�  "   �� 5�  "   �� 5�  "   �� 5�  "   �� 5�  "   
 5�     �� 5�  "   $
��Auto �63   �� 5�  "   �� 5�  "   $
��Auto �63   .+�5�     �� -z   5        $��NameSurname��5�  $   $��0��67   $��0��6G   $��Imię i Nazwisko��6T   $��Center=�6n   $��3q�6�   �� 5�     -{   5        $��txtNameSurname��5�  &   $��1��6^   $��0��6n   $��Center=�6{   $��3q�6�   ��6<   �� $ NameSurname�6�   �� 5�     -|   5        $��btnNameSurname��5�  %   $��2��6;   $��0��6K   $	��...��6X   $��Center=�6f   $
��10,3q�6�   $��3q�6�   �� 5�     -}   5        $��Email��5�  $   $��0��61   $��1��6A   $��Email��6N   $��Center=�6^   $��3q�6y   �� 5�     -~   5        $��txtEmail��5�  &   $��1��6R   $��1��6b   $��Center=�6o   $��3q�6�   ��66   �� $ Email�6�   �� 5�     -   5        $��btnEmail��5�  %   $��2��65   $��1��6E   $	��...��6R   $��Center=�6`   $
��10,3q�6{   $��3q�6�   �� 5�     -�   5        $
��Date��5�  $   $��Data urodzenia��60   $��0��6I   $��2��6Y   $��Center=�6g   $��3q�6�     5�     -�   5        $��datepick��5�  )   $��1��6c   $��2��6s   $��5,5,5,5q�6�   $��2��6�    69   �� $ dateOfBirth�6�   �� 5�     -�   5        $��Payment��5�  $   $��Wpłata��63   $��0��6D   $��3��6T   $��Center=�6b   $��3q�6}   �� 5�     -�   5        $��scrollbarPayment��5�  (   $��1��6_   $��3��6o   $ 
Horizontal=�6|    6@   �� $ Payment�6�   �� 5�     -�   5        $��
txtPayment��5�  &   $��2��68   $��3��6H   $��Center=�6V   $
��10,3q�6q   $��3q�6�   �� 5�     -�   5        $��Province��5�  $   $��Województwo��64   $��0��6K   $��4��6[   $��Center=�6h   $��3,0,3,0q�6�   �� 5�     -�   5        $��cmbProvince��5�  '   $��1��6b   $��4��6r   $��Center=�6   $��2��6�   $��2,7,4,6.667q�6�    6:   �� $ Province�.@�5�  "   �� -�   5        $
��cmb1��5�  /   $��Podlasie��6;   �� 5�  "   -�   5        $
��cmb2��5�  /   $��	Łódzkie��6;   �� 5�  "   -�   5        $
��cmb3��5�  /   $��Mazowieckie��6;   �� 5�  "   -�   5        $
��cmb4��5�  /   $��Małoposlkie��6;   �� 5�  "   -�   5        $
��cmb5��5�  /   $��Wielkopolskie��6;   �� 5�  "   -�   5        $
��cmb6��5�  /   $��	Pomorskie��6;   5�     �� 5�     -�   5        $��Format1��5�  '   $��Adres��66   $��0��6E   $��5��6U   $��3��6b   $��3q�6v   .��5�  "   � $��Center=�6'   	 5�  &   �� 5�  *   $
��Auto �68   �� 5�  *   $
��Auto �68   �� 5�  *   $
��Auto �68   
 5�  &   �� 5�  *   $��60 �6;   �� 5�  *   $��60 �6;   �� 5�  *   $��40 �6;   �� 5�  *   $��60 �6;   �� 5�  *   $��50 �6;   �� 5�  *   $��60 �6;   �� 5�  *   .+�5�  &   �� -�   5        $��Street��5�  ,   $��Miasto��6:   $��0��6K   $��3,0,3,0q�6[   $��Center=�6l   $��2��6�   $��26��6�   �� 5�  &   -�   5        $
��City��5�  ,   $��Ulica��68   $��1��6H   $��0��6U   $��3,0,3,0q�6e   $��Center=�6v   $��2��6�   $��26��6�   �� 5�  &   -�   5        $
��Code��5�  ,   $	��Kod��68   $��2��6F   $��2��6V   $��3,0,4,0q�6c   $��Center=�6t   $��26��6�   �� 5�  &   -�   5        $��Phone��5�  ,   $��Telefon��69   $��4��6K   $��2��6[   $��3,0,3,0q�6h   $��Center=�6y   $��2��6�   $��26��6�   �� 5�  &   -�   5        $��txtCity��5�  .   $��2��6X   $��3,0,4,0q�6h   $��Center=�6y   $��18��6�   $��10��6�   ��6=   �� $
 City�6�   �� 5�  &   -�   5        $��	txtStreet��5�  .   $��2��6\   $��1��6l   $��3,0,4,0q�6y   $��Center=�6�   $��18��6�   $��10��6�   ��6?   �� $ Street�6�   �� 5�  &   -�   5        $��txtCode��5�  .   $��3��6X   $��2��6h   $��0,0,4,0q�6u   $��Center=�6�   $��18��6�   $��1��6�   ��6=   �� $
 Code�6�   �� 5�  &   -�   5        $��txtPhone��5�  .   $��5��6[   $��2��6k   $��0,0,4,0q�6x   $��Center=�6�   $��18��6�   $��2��6�   ��6?   �� $ Phone�6�   5�  #   5�     5�     � 5�     $��2��6   
 5�     �� 5�  "   $��* �63   �� 5�  "   $��* �63   �� 5�  "   $��* �63   .+�5�     �� -�   5        $��Gender��5�  '   $��Płeć��65   $��0��6C   .��5�  "   �� $��Center=�6-   .+�5�  &   	� -�   5        $
��male��5�  2   $��Mężczyzna��6>   $��3q�6R   	� 5�  &   -�   5        $��female��5�  2   $��Kobieta��6@   $��3q�6R   	� 5�  &   -�   5        $��unknown��5�  2   $��Nieznane��6A   $��3q�6T   5�  #   5�     �� 5�     -�   5        $��Adres��5�  '   $��Rodzaj wpłaty��64   $��1��6K   .��5�  "   �� $	��Top=�6-   .+�5�  &   �� -�   5         ��Name$ Oplata��5�  /   $��Opłata ...?��6?   $��1��6V   $��0��6f   $��Center=�6s   $��3,0,3,0q�6�   �� 5�  &   -�   5        $ Charytatywne��5�  /   $��Na cele charytatywne��6E   $��2��6d   $��0��6t   $��Center=�6�   $��3,0,3,0q�6�   �� 5�  &   -�   5        $ Napiwek��5�  /   $��Napiwek��6@   $��2��6R   $��0��6b   $��Center=�6o   $��3,0,3,0q�6�   5�  #   5�     �� 5�     -�   5        $��Termin_Realizacji��5�  '   $��Termin Realizacji��6@   $��2��6[   .��5�  "   �� $	��Top=�6-   .+�5�  &   	� -�   5        $��Standard��5�  2   $��Standard��6B   $��3q�6U   	� 5�  &   -�   5        $��Ekspres��5�  2   $��Ekspres��6A   $��3q�6S   5�  #   5�     5�     � 5�     $��3��6   
 5�     �� 5   "   $��* �63   �� 5  "   $��* �63   �� 5  "   $��* �63   .+�5     �� $��Dodatkowe uwagi:��6$   $��0��6?   $��2��6O   $��Center=�6\   $��28��6x   $��3,0,3,0q�6�   �� 5     -�   5        $��
btnSummary��5  %   $��Sprawdź��68   $��2��6J   $��2��6Z   $��Center=�6g    . $��3,0,3,0q�6�   6�   5     �� 5	     -�   5        $��
txtSummary��5	  "   $��0��6V   $��4��6f   $
 Wrap=�6s    . $ Visible=�6�   $��10,5,3,3q�6�   ��64   �� $ Description�6�   �� 5     $��5��6%   $ 
Horizontal=�62   $��Center=�6K   $��Right=�6f   .+�5     �� -�   5        $��btnOk��5  %   $��Dodaj nową osobę��62   $
��20,3q�6M   $��3q�6\    . 6x   �� 5     -�   5        $��	btnCancel��5  %   $��Anuluj��66   $
��20,3q�6G   $��3q�6V    . 6q   5     5     � 5     $
��Left=�6^   $	��487��6y   $��
1140,0,0,0q�6�   $��Center=�6�   $	��350��6�    6   �� $ listOfItems��$ SelectedItem�	 5     �� 5     �� 5     �� 5     �� 5     
 5     �� 5     $
��auto �6/    z� SharedSizeGroup$ 	etykiety2��6<   �� 5     .+�5     �� $��4q�6    $��0��6+   .��68   
Urodzony6B   �� 5      $��4q�6    $��1��6+   .��68   Płeć6>   �� 5!     $��4q�6    $��2��6+   .��68   Rodzaj6@   �� 5"     $��4q�6    $��3��6+   .��68   
Realizacja6D   �� 5#     $��4q�6"   $��0��6-   $��1��6:   ��6J   �� $ DateOfBirth��� 5$     $��4q�6"   $��1��6-   $��1��6:   ��6J   �� $ Gender��� 5%     $��4q�6"   $��2��6-   $��1��6:   ��6J   �� $
 Type��� 5&     $��4q�6"   $��3��6-   $��1��6:   ��6J   �� $
 Term�5'     5(     5)     5*     5+     5,     