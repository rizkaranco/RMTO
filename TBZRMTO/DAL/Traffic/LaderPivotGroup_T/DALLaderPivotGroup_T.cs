using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;
using HPS.DAL.DataLayerMain;


namespace HPS.DAL.LaderPivotGroupDAL
{
class DALLaderPivotGroup_T: DataLayerBase
{

public DALLaderPivotGroup_T():base(Hepsa.Core.Common.ConnectionString.ConnectionString)
{
}

public void Insert(HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T businessObject){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LaderPivotGroup_T_Add]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LaderPivotGroupID_int =new SqlParameter();
LaderPivotGroupID_int.ParameterName = "@LaderPivotGroupID_int";
LaderPivotGroupID_int.SqlDbType = SqlDbType.Int;
LaderPivotGroupID_int.Direction = ParameterDirection.Output;
LaderPivotGroupID_int.IsNullable = false;
LaderPivotGroupID_int.Value = businessObject.LaderPivotGroupID_int;
this.Command.Parameters.Add(LaderPivotGroupID_int);

SqlParameter LaderPivotGroup_nvc =new SqlParameter();
LaderPivotGroup_nvc.ParameterName = "@LaderPivotGroup_nvc";
LaderPivotGroup_nvc.SqlDbType = SqlDbType.NVarChar;
LaderPivotGroup_nvc.Direction = ParameterDirection.Input;
LaderPivotGroup_nvc.IsNullable = false;
LaderPivotGroup_nvc.Value = businessObject.LaderPivotGroup_nvc;
this.Command.Parameters.Add(LaderPivotGroup_nvc);



if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

businessObject.LaderPivotGroupID_int = (Int32?)(this.Command.Parameters["@LaderPivotGroupID_int"].Value);

if(ControlConnection) {
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public void Update(HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T businessObject,HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LaderPivotGroup_T_Update]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LaderPivotGroup_nvc =new SqlParameter();
LaderPivotGroup_nvc.ParameterName = "@LaderPivotGroup_nvc";
LaderPivotGroup_nvc.SqlDbType = SqlDbType.NVarChar;
LaderPivotGroup_nvc.Direction = ParameterDirection.Input;
LaderPivotGroup_nvc.IsNullable = false;
LaderPivotGroup_nvc.Value = businessObject.LaderPivotGroup_nvc;
this.Command.Parameters.Add(LaderPivotGroup_nvc);


SqlParameter pk_LaderPivotGroupID_int =new SqlParameter();
pk_LaderPivotGroupID_int.ParameterName = "@pk_LaderPivotGroupID_int";
pk_LaderPivotGroupID_int.SqlDbType = SqlDbType.Int;
pk_LaderPivotGroupID_int.Direction = ParameterDirection.Input;
pk_LaderPivotGroupID_int.IsNullable = false;
pk_LaderPivotGroupID_int.Value = businessObjectKey.LaderPivotGroupID_int;
this.Command.Parameters.Add(pk_LaderPivotGroupID_int);



if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

if(ControlConnection) {
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public List< HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T> SelectAll() { 
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LaderPivotGroup_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T> Result  =new  List< HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T>();
Result = PopulateObjectsFromReader(dataReader);

if(dataReader.IsClosed == false ){
dataReader.Close();
}

if(ControlConnection ){
this.Commit();
}

return Result;}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectAll(ref System.Data.DataSet dataset,String srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LaderPivotGroup_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset, srcTable);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectAll(ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LaderPivotGroup_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectAll(ref System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LaderPivotGroup_T_SelectAll]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataTable);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T SelectByPrimaryKey(HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LaderPivotGroup_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LaderPivotGroupID_int =new SqlParameter();
LaderPivotGroupID_int.ParameterName = "@LaderPivotGroupID_int";
LaderPivotGroupID_int.SqlDbType = SqlDbType.Int;
LaderPivotGroupID_int.Direction = ParameterDirection.Input;
LaderPivotGroupID_int.IsNullable = false;
LaderPivotGroupID_int.Value = businessObjectKey.LaderPivotGroupID_int;
this.Command.Parameters.Add(LaderPivotGroupID_int);



if(ControlConnection) {
this.BeginTransaction();
}

IDataReader dataReader = this.Command.ExecuteReader();
HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T businessObject=new HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T();
if(dataReader.Read()) {
PopulateBusinessObjectFromReader(businessObject, dataReader);
}else{
businessObject = null;
}

if(dataReader.IsClosed == false) {
dataReader.Close();
}


if(ControlConnection) {
this.Commit();
}
return businessObject;}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public void SelectByPrimaryKey(HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TKeys businessObjectKey , ref System.Data.DataSet dataset,String  srcTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LaderPivotGroup_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LaderPivotGroupID_int =new SqlParameter();
LaderPivotGroupID_int.ParameterName = "@LaderPivotGroupID_int";
LaderPivotGroupID_int.SqlDbType = SqlDbType.Int;
LaderPivotGroupID_int.Direction = ParameterDirection.Input;
LaderPivotGroupID_int.IsNullable = false;
LaderPivotGroupID_int.Value = businessObjectKey.LaderPivotGroupID_int;
this.Command.Parameters.Add(LaderPivotGroupID_int);


if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset, srcTable);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByPrimaryKey(HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TKeys businessObjectKey, ref System.Data.DataSet dataset){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LaderPivotGroup_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LaderPivotGroupID_int =new SqlParameter();
LaderPivotGroupID_int.ParameterName = "@LaderPivotGroupID_int";
LaderPivotGroupID_int.SqlDbType = SqlDbType.Int;
LaderPivotGroupID_int.Direction = ParameterDirection.Input;
LaderPivotGroupID_int.IsNullable = false;
LaderPivotGroupID_int.Value = businessObjectKey.LaderPivotGroupID_int;
this.Command.Parameters.Add(LaderPivotGroupID_int);


if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByPrimaryKey(HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TKeys businessObjectKey,ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LaderPivotGroup_T_SelectByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LaderPivotGroupID_int =new SqlParameter();
LaderPivotGroupID_int.ParameterName = "@LaderPivotGroupID_int";
LaderPivotGroupID_int.SqlDbType = SqlDbType.Int;
LaderPivotGroupID_int.Direction = ParameterDirection.Input;
LaderPivotGroupID_int.IsNullable = false;
LaderPivotGroupID_int.Value = businessObjectKey.LaderPivotGroupID_int;
this.Command.Parameters.Add(LaderPivotGroupID_int);



if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataTable);

if(ControlConnection ){
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}





public List< HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T> SelectByField(String fieldName  ,Object  value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LaderPivotGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{

this.Command.Parameters.Clear();

if(ControlConnection ){
this.BeginTransaction();
}

this.Command.Parameters.Add(new SqlParameter("@Condition","[LaderPivotGroup_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

IDataReader dataReader = this.Command.ExecuteReader();
List< HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T> Result = new List< HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T>();
Result = PopulateObjectsFromReader(dataReader);

if(dataReader.IsClosed == false ){
dataReader.Close();
}

if(ControlConnection ){
this.Commit();
}

return Result;}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByField(String fieldName ,Object  value  , ref System.Data.DataSet dataset  ,String  srcTable  ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LaderPivotGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[LaderPivotGroup_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset, srcTable);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByField(String fieldName  ,Object  value  , ref System.Data.DataSet dataset  ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LaderPivotGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[LaderPivotGroup_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByField(String fieldName  ,Object  value  , ref  System.Data.DataTable dataTable){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LaderPivotGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition","[LaderPivotGroup_T]."+ fieldName + " = N" + "'" + value.ToString() + "'"));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataTable);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public List<HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T> SelectByCondition(String Condition){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LaderPivotGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

IDataReader dataReader   = this.Command.ExecuteReader();
List<HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T> Result= new List<HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T>();
Result = PopulateObjectsFromReader(dataReader);

if(dataReader.IsClosed == false ){
dataReader.Close();
}

if(ControlConnection ){
this.Commit();
}

return Result;}
catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByCondition(String Condition  , ref System.Data.DataSet dataset,String srcTable ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LaderPivotGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset, srcTable);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByCondition(String Condition  ,ref System.Data.DataSet dataset ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LaderPivotGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection ){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataset);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void SelectByCondition(String Condition  , ref System.Data.DataTable dataTable ){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
SqlDataAdapter sqlDataAdapter=new System.Data.SqlClient.SqlDataAdapter(this.Command);
this.Command.CommandText = "[sp_LaderPivotGroup_T_SelectCondition]";
this.Command.CommandType = CommandType.StoredProcedure;
try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@Condition", Condition));

if(ControlConnection){
this.BeginTransaction();
}

sqlDataAdapter.Fill(dataTable);

if(ControlConnection ){
this.Commit();
}}

catch (System.Exception ex){
if(ControlConnection ){
this.RollBack();
}
throw ex;
}
}

public void Delete(HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_TKeys businessObjectKey){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LaderPivotGroup_T_DeleteByPrimaryKey]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

SqlParameter LaderPivotGroupID_int =new SqlParameter();
LaderPivotGroupID_int.ParameterName = "@LaderPivotGroupID_int";
LaderPivotGroupID_int.SqlDbType = SqlDbType.Int;
LaderPivotGroupID_int.Direction = ParameterDirection.Input;
LaderPivotGroupID_int.IsNullable = false;
LaderPivotGroupID_int.Value = businessObjectKey.LaderPivotGroupID_int;
this.Command.Parameters.Add(LaderPivotGroupID_int);


if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

if(ControlConnection) {
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public void DeleteByField(String fieldName,Object value){
bool ControlConnection = ! (this.ConnectionState == System.Data.ConnectionState.Open);
this.Command.CommandText = "[sp_LaderPivotGroup_T_DeleteByField]";
this.Command.CommandType = CommandType.StoredProcedure;

try{
this.Command.Parameters.Clear();

this.Command.Parameters.Add(new SqlParameter("@FieldName", fieldName));
this.Command.Parameters.Add(new SqlParameter("@Value", value));

if(ControlConnection) {
this.BeginTransaction();
}

this.Command.ExecuteNonQuery();

if(ControlConnection) {
this.Commit();
}}
catch (System.Exception ex){
if(ControlConnection) {
this.RollBack();
}
throw ex;
}
}

public void PopulateBusinessObjectFromReader(  HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T businessObject,IDataReader dataReader){
businessObject.LaderPivotGroupID_int = dataReader.GetInt32(dataReader.GetOrdinal(HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T.LaderPivotGroup_TField.LaderPivotGroupID_int.ToString()));
businessObject.LaderPivotGroup_nvc = dataReader.GetString(dataReader.GetOrdinal(HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T.LaderPivotGroup_TField.LaderPivotGroup_nvc.ToString()));
}

public List< HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T> PopulateObjectsFromReader(IDataReader dataReader){
List< HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T> list=new List< HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T>();
while (dataReader.Read()){
HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T businessObject =new HPS.BLL.LaderPivotGroupBLL.BLLLaderPivotGroup_T();
PopulateBusinessObjectFromReader(businessObject, dataReader);
list.Add(businessObject);
}
return list;
}

}
} 