#!/usr/bin/env groovy
//Leave the above line alone.  It identifies this as a groovy script.
@Library('vs-steps-build') _

<<<<<<< HEAD
    
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
            [ts_version: '2017', vs_year_version: '2017', x64_build_flag: false, sp_version: 0],
            [ts_version: '2017', vs_year_version: '2015', x64_build_flag: false, sp_version: 1],
            [ts_version: '2017', vs_year_version: '2016', x64_build_flag: false, sp_version: 0],
            [ts_version: '2017', vs_year_version: '2017', x64_build_flag: false, sp_version: 0],
            [ts_version: '2017', vs_year_version: '2015', x64_build_flag: true, sp_version: 1],
            [ts_version: '2017', vs_year_version: '2016', x64_build_flag: true, sp_version: 0],
            [ts_version: '2017', vs_year_version: '2017', x64_build_flag: true, sp_version: 0]]
             
        build_list.each { buildConfiguration ->
            veristandStepsPipeline(branch, org, release_version, buildConfiguration)
        }
    }
}
=======
def lvVersions = ['2017','2016','2015']

ni.vsbuild.PipelineExecutor.execute(this, lvVersions)
>>>>>>> pr/11
