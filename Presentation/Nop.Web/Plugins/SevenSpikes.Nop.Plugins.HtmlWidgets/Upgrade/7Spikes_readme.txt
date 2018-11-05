﻿Steps:
1. Backup your existing database
2. If you haven't upgraded your nopCommerce website to version 3.6 already, then follow the instructions in the "nopCommerce_readme.txt".
3. Copy this plugin and the "SevenSpikes.Core" plugin folders to the Plugins folder of nopCommerce.
4. Execute 7Spikes_upgrade.sql script over your database.
5. Start your site. If you have made any changes to this plugin in 3.5 then you need to merge them in the new version of the plugin.

Note: If you are upgrading from an older version, you will need to run multiple upgrade scripts in a sequential order.
For example, if you are upgrading from 3.40 to 3.60 you need to run the following upgrade scripts: 
- nopCommerce-upgrade-3.40-3.50.sql
- 7Spikes-upgrade-3.40-3.50.sql
- nopCommerce_upgrade-3.50-3.60.sql
- 7Spikes_upgrade-3.50-3.60.sql

You can find all of the scripts here: http://nop-templates.com/Help/UpgradeScripts/UpgradeScripts.zip