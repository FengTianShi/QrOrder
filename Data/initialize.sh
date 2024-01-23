#!/bin/bash

sudo -u postgres psql -U postgres -d postgres -c "\i ./SQL/DATABASE.SQL"
sudo -u postgres psql -U postgres -d qrorder -c "\i ./SQL/TABLES.SQL"
