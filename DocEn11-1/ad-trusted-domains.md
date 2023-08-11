# Trusted Domain List Setup
      
Alvao can also import information about group members who come from other trusted domains. If these domains are not known in the default domain tree, you need to manually enter a list of trusted domains into the [AdTrustedDomain](../../../customization/database) table.
      
Example of enrolling two different trusted domains:

1. Edit the [AdTrustedDomain](../../../customization/database#U_AdTrustedDomain) table using, for example, Microsoft SQL Server Management Studio.
2. Enter the value "SERVER1" in the "Hostname" column and "alvao.cz" in the "DomainName" column in the first row of the table.
3. In the second row of the table, in the "Hostname" column, insert the value "SERVER2" and in the "DomainName" column the value "test.alvao.cz"

> [!TIP]
> If you are using domain replication, you can enter all the servers running the replicated domain controller in the table. Also set the correct order in which the servers will be tried in the "Order" column. The import will then try all the servers in turn, and if it fails to connect to even one, it will end with an error.
