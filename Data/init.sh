#!/bin/bash

work=$(uuidgen)

sudo mkdir /$work
sudo cp -r ./SQL/* /$work
sudo chown -R postgres:postgres /$work

sudo -u postgres psql -U postgres -d postgres -c "\i /$work/database.sql"
sudo -u postgres psql -U postgres -d qrorder -c "\i /$work/restaurant.sql"

sudo rm -rf /$work