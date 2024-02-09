#!/bin/bash

uuid=$(uuidgen)

sudo mkdir /$uuid
sudo cp -r ./SQL/* /$uuid
sudo chown -R postgres:postgres /$uuid

sudo -u postgres psql -U postgres -d postgres -c "\i /$uuid/database.sql"
sudo -u postgres psql -U postgres -d qrorder -c "\i /$uuid/restaurant.sql"

sudo rm -rf /$uuid