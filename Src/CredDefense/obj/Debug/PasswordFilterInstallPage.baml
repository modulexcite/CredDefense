   M S B A M L   `   `   `  ����F  BCredDefense, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CredDefenseCredDefense  5      +    %CredDefense.PasswordFilterInstallPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:CredDefense     5        N� Title$  PasswordFilter��5	      .��5      � $��
10,0,10,10q�6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      �� 5      $
��Auto �6   .+�5   
   �� $��1��6   $��Center=�6    $��Trebuchet MS)�6;   $
��Bold"�5   	   $��18(�6   ���#0066cc$��	0,41,1,38q�6>   .��5      �� $��WrapWithOverflow=�6   �� 69   $�Password Filter ��6=   �� 6W   �� 6c   $�Install/Uninstall��6g   6�   5      �� 5   
   $��0��6   $��1��6!   $��35��6.    �� Padding$ 5q�6:   ���#4E87D4._�5       �� $��Center=�6   
�������.��6B   Unconfigured DCs6T   5!      �� 5"   
   -   5        $��installDomainControllers��5"   0   $��0��6   $��2��6#   ��6P   �� *#!UnconfiguredDomainControllersList+ �� Mode$ OneWay=�6�   �� 5#   
   -   5        $��0��5#      $��3��6!   $��0,10,0,0q�6.   $	��125��6@   $��25��5$      $��Right=�6   .��6J   	Install6S   �� 5&   
   $��2��6   $��1��6!   $��35��6.   $ 5q�6:   ���#4E87D4._�5'      �� $��Center=�6   
�������.��6B   	Installed6M   5(      �� 5)   
   -   5        $ ��uninstallDomainControllers��5)   0   $��2��6   $��2��6#   ��6R   �� *!ConfiguredDomainControllersList+$ OneWay=�6�   �� 5*   
   -   5        $��2��5*      $��3��6!   $��0,10,0,0q�6.   $	��125��6@   $��25��5+      $��Right=�6   .��6L   	Uninstall6W   5-      5.      