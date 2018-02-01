#!/usr/bin/env groovy
node{
    stage("Cleanup"){
        cleanWs()
    }
    
    branch="master"
    org="adchurch"
    release_version="7.${script.currentBuild.number}"
    
    stage("build"){
        
        build_list = [
            [ts_version: '2014', vs_year_version: '2015', x64_build_flag: false, sp_version: 1],
            [ts_version: '2014', vs_year_version: '2015', x64_build_flag: true, sp_version: 1],
            [ts_version: '2014', vs_year_version: '2016', x64_build_flag: false, sp_version: 0],
            [ts_version: '2014', vs_year_version: '2016', x64_build_flag: true, sp_version: 0],
            [ts_version: '2014', vs_year_version: '2017', x64_build_flag: false, sp_version: 0],
            [ts_version: '2014', vs_year_version: '2017', x64_build_flag: true, sp_version: 0],
            [ts_version: '2016', vs_year_version: '2015', x64_build_flag: false, sp_version: 1],
            [ts_version: '2016', vs_year_version: '2015', x64_build_flag: true, sp_version: 1],
            [ts_version: '2016', vs_year_version: '2016', x64_build_flag: false, sp_version: 0],
            [ts_version: '2016', vs_year_version: '2016', x64_build_flag: true, sp_version: 0],
            [ts_version: '2016', vs_year_version: '2017', x64_build_flag: false, sp_version: 0],
            [ts_version: '2016', vs_year_version: '2017', x64_build_flag: true, sp_version: 0],
            [ts_version: '2017', vs_year_version: '2017', x64_build_flag: false, sp_version: 0]]
             
        build_list.each { buildConfiguration ->
            veristandStepsPipeline(branch, org, release_version, buildConfiguration)
        }
    }
}
