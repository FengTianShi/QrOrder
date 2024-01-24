#!/bin/bash

uuid=$(uuidgen)

sudo mkdir /$uuid
sudo cp -r ./SQL/* /$uuid
sudo chmod 777 -r /$uuid

sudo -u postgres psql -U postgres -d postgres -c "\i $SQL_PATH/"DB.SQL"
sudo -u postgres psql -U postgres -d qrorder -c "\i $SQL_PATH/"TABLE.SQL"

sudo rm -rf /$uuid