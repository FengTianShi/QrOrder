#!/bin/bash

uuid=$(uuidgen)

sudo cp ./SQL /$uuid
sudo chmod 777 -R /$uuid

sudo -u postgres psql -U postgres -d postgres -c "\i $SQL_PATH/"DB.SQL"
sudo -u postgres psql -U postgres -d qrorder -c "\i $SQL_PATH/"TABLE.SQL"

sudo rm -rf /$uuid