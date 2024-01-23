sudo -u postgres psql -U postgres -d postgres -a -f ./DROP.SQL
\q
sudo -u postgres psql -U postgres -d qrorder -a -f ./CREATE.SQL
\q